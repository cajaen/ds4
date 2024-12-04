using System.Web.Http;
using System.Data.SqlClient;
using DesafioDePescaAPI.App_Start;
using System.Collections.Generic;
using System.Data;
using System;

namespace DesafioDePescaAPI.Controllers
{
    [RoutePrefix("api/usuarios")]
    public class UsuariosController : ApiController
    {
        private readonly BD _db;

        public UsuariosController()
        {
            _db = new BD(@"Server=.\SQLEXPRESS;Database=DesafioDePescaDB;Trusted_Connection=True;");
        }

        [HttpPost]
        [Route("Registrar")]
        public IHttpActionResult RegistrarUsuario([FromBody] UsuarioRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Nombre) || string.IsNullOrWhiteSpace(request.Correo))
            {
                return BadRequest("El nombre y el correo son obligatorios.");
            }

            string query = "INSERT INTO Usuarios (Nombre, Correo) VALUES (@Nombre, @Correo)";
            SqlParameter[] parameters =  {
                new SqlParameter("@Nombre", request.Nombre),
                new SqlParameter("@Correo", request.Correo)
            };

            int rowsAffected = _db.ExecuteCommand(query, parameters);
            if (rowsAffected > 0)
                return Ok("Usuario registrado exitosamente.");
            return BadRequest("No se pudo registrar el usuario.");
        }

        [HttpGet]
        [Route("Verificar")]
        public IHttpActionResult VerificarUsuario(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
            {
                return BadRequest("El correo es obligatorio.");
            }

            string query = "SELECT Id AS UsuarioId, Nombre FROM Usuarios WHERE Correo = @Correo"; // Alias 'UsuarioId'
            SqlParameter[] parameters = {
                new SqlParameter("@Correo", correo)
            };

            var userTable = _db.ExecuteQuery(query, parameters);
            if (userTable.Rows.Count == 1)
            {
                return Ok(new
                {
                    UsuarioId = userTable.Rows[0]["UsuarioId"],
                    Nombre = userTable.Rows[0]["Nombre"]
                });
            }
            return NotFound();
        }

        [HttpGet]
        [Route("ObtenerUsuarios")]
        public IHttpActionResult ObtenerUsuarios()
        {
            try
            {
                string query = "SELECT Id, Nombre, Correo FROM Usuarios";
                var resultTable = _db.ExecuteQuery(query);

                if (resultTable.Rows.Count > 0)
                {
                    var usuarios = new List<object>();
                    foreach (DataRow row in resultTable.Rows)
                    {
                        usuarios.Add(new
                        {
                            Id = row["Id"],
                            Nombre = row["Nombre"],
                            Correo = row["Correo"]
                        });
                    }
                    return Ok(usuarios);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(new Exception($"Error en ObtenerUsuarios: {ex.Message}"));
            }
        }

        // Clase para deserializar la solicitud
        public class UsuarioRequest
        {
            public string Nombre { get; set; }
            public string Correo { get; set; }
        }
    }
}