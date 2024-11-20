using System;
using System.Data.SqlClient;

namespace Parcial3_1
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Código que se ejecuta al cargar la página (si es necesario).
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(txtNombreJuego.Text) ||
                string.IsNullOrWhiteSpace(txtFechaJuego.Text) ||
                string.IsNullOrWhiteSpace(txtCiudadJuego.Text))
            {
                lblMensaje.Text = "Por favor, complete todos los campos.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }

            try
            {
                // Definir la cadena de conexión (debe coincidir con el nombre en web.config)
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexiónLoteriaNacional"].ConnectionString;

                // Definir la consulta SQL
                string query = "INSERT INTO Juegos (NombreJuego, FechaJuego, CiudadJuego) VALUES (@NombreJuego, @FechaJuego, @CiudadJuego)";

                // Abrir conexión y ejecutar el comando
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar los parámetros con los valores de los campos
                        command.Parameters.AddWithValue("@NombreJuego", txtNombreJuego.Text);
                        command.Parameters.AddWithValue("@FechaJuego", DateTime.Parse(txtFechaJuego.Text));
                        command.Parameters.AddWithValue("@CiudadJuego", txtCiudadJuego.Text);

                        connection.Open();
                        command.ExecuteNonQuery();

                        // Mostrar mensaje de éxito
                        lblMensaje.Text = "El juego ha sido registrado correctamente.";
                        lblMensaje.ForeColor = System.Drawing.Color.Green;

                        // Limpiar los campos
                        txtNombreJuego.Text = "";
                        txtFechaJuego.Text = "";
                        txtCiudadJuego.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                lblMensaje.Text = "Error al registrar el juego: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
