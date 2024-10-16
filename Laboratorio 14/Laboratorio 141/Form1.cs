using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_141
{
    public partial class frmProductos : Form
    {
        string connectionString = @"Server=.\sqlexpress;Database=productos;Trusted_Connection=True;";
        bool nuevo;

        public frmProductos()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            tsbBuscar.Enabled = false;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            txtNombre.Focus();
            nuevo = true;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {
                string sql = "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK) VALUES(@nombre, @precio, @stock)";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);
                cmd.Parameters.AddWithValue("@stock", txtStock.Text);

                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro ingresado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                string sql = "UPDATE LAPTOPS SET NOMBRE=@nombre, PRECIO=@precio, STOCK=@stock WHERE id=@id";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);
                cmd.Parameters.AddWithValue("@stock", txtStock.Text);
                cmd.Parameters.AddWithValue("@id", txtId.Text);

                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro actualizado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }

            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM LAPTOPS WHERE ID=@id";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", txtId.Text);

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro eliminado correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM LAPTOPS WHERE ID=@id";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", tstId.Text); 
            SqlDataReader reader;

            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    txtId.Enabled = false;
                    tsbBuscar.Enabled = false;
                    txtNombre.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtStock.Enabled = true;
                    txtNombre.Focus();
                    txtId.Text = reader["ID"].ToString();
                    txtNombre.Text = reader["NOMBRE"].ToString();
                    txtPrecio.Text = reader["PRECIO"].ToString();
                    txtStock.Text = reader["STOCK"].ToString();
                    nuevo = false;
                }
                else
                    MessageBox.Show("¡Ningún registro encontrado con el ID ingresado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            tstId.Text = "";
        }

        private void tstId_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


