using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.UI;

namespace DesafioDePescaAPP
{
    public partial class Login : Page
    {
        protected async void btnRegister_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim(); // Usa txtNombre para el nombre del usuario
            string correo = txtCorreoRegistro.Text.Trim(); // Usa txtCorreoRegistro para el registro

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo))
            {
                lblMessage.Text = "Todos los campos son obligatorios.";
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44313/api/usuarios/");
                var content = new StringContent($"{{\"nombre\":\"{nombre}\",\"correo\":\"{correo}\"}}", Encoding.UTF8, "application/json");
                var response = await client.PostAsync("registrar", content);

                if (response.IsSuccessStatusCode)
                {
                    lblMessage.Text = "Usuario registrado exitosamente. Ahora puedes iniciar sesión.";
                }
                else
                {
                    lblMessage.Text = "Error al registrar el usuario.";
                }
            }
        }

        protected async void btnLogin_Click(object sender, EventArgs e)
        {
            string correo = txtCorreoLogin.Text.Trim(); // Obtiene el correo ingresado

            if (string.IsNullOrWhiteSpace(correo))
            {
                lblMessage.Text = "El correo es obligatorio.";
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44313/api/usuarios/");

                try
                {
                    // Cambiamos POST por GET para buscar el usuario
                    var response = await client.GetAsync($"verificar?correo={correo}");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var user = JsonSerializer.Deserialize<UserResponse>(jsonString);

                        if (user != null)
                        {
                            // Guarda los datos en la sesión
                            Session["UsuarioId"] = user.UsuarioId; // Asegúrate de que esta propiedad existe
                            Session["NombreUsuario"] = user.Nombre;

                            // Verifica si la sesión se guardó correctamente
                            if (Session["UsuarioId"] != null && Session["NombreUsuario"] != null)
                            {
                                Response.Redirect("Game.aspx", false);
                            }
                            else
                            {
                                lblMessage.Text = "Error al guardar la sesión. Por favor, inténtalo nuevamente.";
                            }
                        }
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        lblMessage.Text = "Usuario no encontrado.";
                    }
                    else
                    {
                        lblMessage.Text = "Error al iniciar sesión. Por favor, verifica tu correo.";
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = $"Error al conectar con el servidor: {ex.Message}";
                }
            }
        }

        private class UserResponse
        {
            public int UsuarioId { get; set; }
            public string Nombre { get; set; }
        }
    }
}