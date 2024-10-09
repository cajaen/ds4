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

namespace Laboratorio_131
{
    public partial class Form1 : Form
    {
        string connectionString =
        @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            try
            {
                conexion.Open();

                SqlCommand command = new SqlCommand("SELECT ProductName FROM [dbo].[Products]", conexion);
                SqlDataReader reader = command.ExecuteReader();

                listBox1.Items.Clear();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader["ProductName"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conexion.Close();
                MessageBox.Show("Se cerró la conexión.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

