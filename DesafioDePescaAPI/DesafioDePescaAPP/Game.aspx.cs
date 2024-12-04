using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Web.UI.WebControls;

namespace DesafioDePescaAPP
{
    public partial class Game : System.Web.UI.Page
    {
        private static Random _random = new Random();
        private static int _posicionPez;
        private static int _intentos;
        private static int _puntaje;
        private static int _puntajeMaximo = 100;  // Puntaje máximo inicial
        private static int _intentosFallidos = 0;  // Contador de intentos fallidos

        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica si la sesión existe
            if (Session["UsuarioId"] == null || Session["NombreUsuario"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                ReiniciarJuego();
                GenerarTablero();
            }
        }

        private void ReiniciarJuego()
        {
            _posicionPez = _random.Next(1, 101);  // Generar posición aleatoria del pez
            _intentosFallidos = 0;  // Reiniciar el contador de intentos fallidos
            _puntaje = _puntajeMaximo;  // Establecer el puntaje al máximo al iniciar el juego

            lblIntentos.Text = _intentosFallidos.ToString();  // Mostrar el número de intentos fallidos
            lblPuntaje.Text = _puntaje.ToString();  // Mostrar el puntaje actual
            lblMensaje.Text = string.Empty;

            btnTerminar.Visible = false;  // Ocultar el botón "Terminar Juego"
        }

        private void GenerarTablero()
        {
            var valores = Enumerable.Range(1, 100).Select(x => x.ToString()).ToList();
            rpTablero.DataSource = valores;
            rpTablero.DataBind();
        }

        protected void Boton_Command(object sender, CommandEventArgs e)
        {
            Button btn = (Button)sender;
            int posicionClicada = int.Parse(e.CommandArgument.ToString());

            // Si el intento es fallido
            if (posicionClicada != _posicionPez)
            {
                _intentosFallidos++;  // Incrementar los intentos fallidos
                _puntaje -= 2;  // Restar 2 puntos por cada intento fallido

                // Asegurarse de que el puntaje no sea negativo
                if (_puntaje < 0) _puntaje = 0;

                lblIntentos.Text = _intentosFallidos.ToString();  // Actualizar el contador de intentos
                lblPuntaje.Text = _puntaje.ToString();  // Actualizar el puntaje

                lblMensaje.Text = $"Pista: {CalcularPista(posicionClicada)}";  // Mostrar una pista

                // Marcar el botón como fallido y deshabilitarlo
                btn.Text = "❌";
                btn.Enabled = false;
            }
            else
            {
                // Si el jugador atrapa el pez
                lblMensaje.Text = "¡Pez atrapado! Juego finalizado.";

                // Marcar el botón como pescado capturado y deshabilitarlo
                btn.Text = "🎣";
                btn.Enabled = false;

                // Mostrar el botón "Terminar Juego"
                btnTerminar.Visible = true;
            }
        }

        private bool EsAdyacente(int posicionClicada, int posicionPez)
        {
            int filaClicada = (posicionClicada - 1) / 10;
            int columnaClicada = (posicionClicada - 1) % 10;

            int filaPez = (posicionPez - 1) / 10;
            int columnaPez = (posicionPez - 1) % 10;

            return Math.Abs(filaClicada - filaPez) <= 1 && Math.Abs(columnaClicada - columnaPez) <= 1;
        }

        private string CalcularPista(int posicionClicada)
        {
            int filaClicada = (posicionClicada - 1) / 10;
            int columnaClicada = (posicionClicada - 1) % 10;

            int filaPez = (_posicionPez - 1) / 10;
            int columnaPez = (_posicionPez - 1) % 10;

            if (filaClicada < filaPez && columnaClicada < columnaPez)
                return "Sureste";
            if (filaClicada < filaPez && columnaClicada > columnaPez)
                return "Suroeste";
            if (filaClicada > filaPez && columnaClicada < columnaPez)
                return "Noreste";
            if (filaClicada > filaPez && columnaClicada > columnaPez)
                return "Noroeste";
            if (filaClicada < filaPez)
                return "Sur";
            if (filaClicada > filaPez)
                return "Norte";
            if (columnaClicada < columnaPez)
                return "Este";
            return "Oeste";
        }

        protected void ReiniciarJuego_Click(object sender, EventArgs e)
        {
            ReiniciarJuego();
            GenerarTablero();
        }

        protected async void TerminarJuego_Click(object sender, EventArgs e)
        {
            int usuarioId = Convert.ToInt32(Session["UsuarioId"]);
            string nombreUsuario = Session["NombreUsuario"].ToString();
            int puntaje = _puntaje;
            int intentos = _intentosFallidos;
            DateTime fecha = DateTime.Now;

            // Validación adicional para evitar errores
            if (usuarioId <= 0 || string.IsNullOrEmpty(nombreUsuario))
            {
                lblMensaje.Text = "Error: Usuario no identificado. Inicia sesión nuevamente.";
                Response.Redirect("Login.aspx");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44313/api/resultados/");

                var resultado = new
                {
                    UsuarioId = usuarioId,
                    NombreUsuario = nombreUsuario,
                    Puntaje = puntaje,
                    NumeroIntentos = intentos,  // Usamos "NumeroIntentos" en vez de "Intentos"
                    Fecha = fecha
                };

                try
                {
                    var content = new StringContent(JsonSerializer.Serialize(resultado), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("GuardarResultado", content);

                    if (response.IsSuccessStatusCode)
                    {
                        lblMensaje.Text = $"Resultados guardados correctamente: Puntaje {puntaje}, Intentos {intentos}.";
                    }
                    else
                    {
                        lblMensaje.Text = "Error al guardar los resultados. Inténtalo nuevamente.";
                    }
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = $"Error al conectar con el servidor: {ex.Message}";
                }
            }

            // Reinicia el juego después de enviar los resultados
            ReiniciarJuego();
            GenerarTablero();
        }

        protected async void MostrarResultados_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44313/api/resultados/");

                try
                {
                    var response = await client.GetAsync("ObtenerResultados");

                    if (response.IsSuccessStatusCode)
                    {
                        // Deserializar la respuesta JSON
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var resultados = JsonSerializer.Deserialize<List<ResultadoResponse>>(jsonString);

                        if (resultados != null && resultados.Any())
                        {
                            // Mostrar todos los resultados
                            string listaTodos = string.Join("<br/>", resultados.Select(r =>
                                $"{r.UsuarioNombre}: Puntaje {r.Puntaje}, Intentos {r.NumeroIntentos}, Fecha {r.Fecha}"));

                            // Mostrar los 3 mejores jugadores
                            var mejores = resultados.OrderByDescending(r => r.Puntaje).Take(3);
                            string listaTop = string.Join("<br/>", mejores.Select(r =>
                                $"{r.UsuarioNombre}: Puntaje {r.Puntaje}, Intentos {r.NumeroIntentos}"));

                            // Mostrar el mensaje
                            lblMensaje.Text = $"<b>Todos los Resultados:</b><br/>{listaTodos}<br/><br/><b>Top 3 Jugadores:</b><br/>{listaTop}";
                        }
                        else
                        {
                            lblMensaje.Text = "No hay resultados disponibles.";
                        }
                    }
                    else
                    {
                        lblMensaje.Text = "Error al cargar los resultados.";
                    }
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = $"Error al conectar con el servidor: {ex.Message}";
                }
            }
        }

        public class ResultadoResponse
        {
            public string UsuarioNombre { get; set; }
            public int Puntaje { get; set; }
            public int NumeroIntentos { get; set; } // Cambiado para coincidir con la base de datos
            public DateTime Fecha { get; set; }
        }
    }
}