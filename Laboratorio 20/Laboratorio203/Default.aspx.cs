using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace Laboratorio203
{
    public partial class frmProductos : Page
    {
        string connectionString = @"Server=.\sqlexpress;Database=productos;Trusted_Connection=True;";
        bool nuevo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InicializarControles();
            }
        }

        private void InicializarControles()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            txtId.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtNombre.Focus();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql;
                if (nuevo)
                {
                    sql = "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK) VALUES (@nombre, @precio, @stock)";
                }
                else
                {
                    sql = "UPDATE LAPTOPS SET NOMBRE=@nombre, PRECIO=@precio, STOCK=@stock WHERE ID=@id";
                }

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (!nuevo)
                    {
                        cmd.Parameters.AddWithValue("@id", txtId.Text);
                    }
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@stock", txtStock.Text);

                    con.Open();
                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            Response.Write("<script>alert('Operación exitosa');</script>");
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write($"<script>alert('Error: {ex.Message}');</script>");
                    }
                }
            }
            InicializarControles();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM LAPTOPS WHERE ID=@id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    con.Open();
                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            Response.Write("<script>alert('Registro eliminado');</script>");
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write($"<script>alert('Error: {ex.Message}');</script>");
                    }
                }
            }
            InicializarControles();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM LAPTOPS WHERE ID=@id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", txtBuscarId.Text);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtId.Text = reader["ID"].ToString();
                        txtNombre.Text = reader["NOMBRE"].ToString();
                        txtPrecio.Text = reader["PRECIO"].ToString();
                        txtStock.Text = reader["STOCK"].ToString();

                        btnNuevo.Enabled = false;
                        btnGuardar.Enabled = true;
                        btnCancelar.Enabled = true;
                        btnEliminar.Enabled = true;
                        txtNombre.Enabled = true;
                        txtPrecio.Enabled = true;
                        txtStock.Enabled = true;
                        nuevo = false;
                    }
                    else
                    {
                        Response.Write("<script>alert('Producto no encontrado');</script>");
                    }
                }
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx"); // Redirige a la página principal o de inicio
        }
    }
}
