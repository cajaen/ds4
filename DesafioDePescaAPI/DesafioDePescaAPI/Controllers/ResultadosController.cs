using System.Web.Http;
using System.Data.SqlClient;
using DesafioDePescaAPI.App_Start;
using System.Collections.Generic;
using System.Data;
using System;

namespace DesafioDePescaAPI.Controllers
{
    [RoutePrefix("api/resultados")]
    public class ResultadosController : ApiController
    {
        private readonly BD _db;

        public ResultadosController()
        {
            _db = new BD(@"Server=.\SQLEXPRESS;Database=DesafioDePescaDB;Trusted_Connection=True;");
        }

        [HttpPost]
        [Route("GuardarResultado")]
        public IHttpActionResult GuardarResultado([FromBody] ResultadoRequest request)
        {
            if (request == null || request.UsuarioId <= 0 || request.Puntaje < 0 || request.NumeroIntentos < 0)
            {
                return BadRequest("Datos inválidos.");
            }

            string query = @"
                INSERT INTO Resultados (UsuarioId, Puntaje, NumeroIntentos, Fecha) 
                VALUES (@UsuarioId, @Puntaje, @NumeroIntentos, @Fecha)";

            SqlParameter[] parameters = {
                new SqlParameter("@UsuarioId", request.UsuarioId),
                new SqlParameter("@Puntaje", request.Puntaje),
                new SqlParameter("@NumeroIntentos", request.NumeroIntentos), // Usar el nombre correcto de la columna
                new SqlParameter("@Fecha", request.Fecha)
            };

            try
            {
                int rowsAffected = _db.ExecuteCommand(query, parameters);
                if (rowsAffected > 0)
                {
                    return Ok("Resultado guardado exitosamente.");
                }
                return InternalServerError(new Exception("No se pudo guardar el resultado."));
            }
            catch (Exception ex)
            {
                return InternalServerError(new Exception($"Error ejecutando comando SQL: {ex.Message}"));
            }
        }

        [HttpGet]
        [Route("ObtenerResultados")]
        public IHttpActionResult ObtenerResultados()
        {
            string query = @"
                SELECT 
                    U.Nombre AS UsuarioNombre, 
                    R.Puntaje, 
                    R.NumeroIntentos, 
                    R.Fecha 
                FROM Resultados R
                JOIN Usuarios U ON U.Id = R.UsuarioId
                ORDER BY R.Fecha DESC";

            var dataTable = _db.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                var resultados = dataTable.AsEnumerable().Select(row => new
                {
                    UsuarioNombre = row["UsuarioNombre"].ToString(),
                    Puntaje = Convert.ToInt32(row["Puntaje"]),
                    NumeroIntentos = Convert.ToInt32(row["NumeroIntentos"]),
                    Fecha = Convert.ToDateTime(row["Fecha"])
                });

                return Ok(resultados);
            }

            return NotFound();
        }

        [HttpGet]
        [Route("TopJugadores")]
        public IHttpActionResult ObtenerRanking()
        {
            string query = @"
                SELECT TOP 10 U.Nombre, R.Puntaje, R.NumeroIntentos, R.Fecha
                FROM Resultados R
                JOIN Usuarios U ON R.UsuarioId = U.Id
                ORDER BY R.Puntaje DESC, R.Fecha ASC";

            var resultTable = _db.ExecuteQuery(query);
            if (resultTable.Rows.Count > 0)
            {
                var ranking = new List<object>();
                foreach (DataRow row in resultTable.Rows)
                {
                    ranking.Add(new
                    {
                        Nombre = row["Nombre"],
                        Puntaje = row["Puntaje"],
                        NumeroIntentos = row["NumeroIntentos"],
                        Fecha = Convert.ToDateTime(row["Fecha"]).ToString("yyyy-MM-dd HH:mm:ss")
                    });
                }
                return Ok(ranking);
            }
            return NotFound();
        }

        public class ResultadoRequest
        {
            public int UsuarioId { get; set; }
            public int NumeroIntentos { get; set; }
            public int Puntaje { get; set; }
            public DateTime Fecha { get; set; }
        }
    }
}