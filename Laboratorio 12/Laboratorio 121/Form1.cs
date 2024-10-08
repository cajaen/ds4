using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Compilar_Click(object sender, EventArgs e)
        {
            try
            {
                
                double velocidad = Convert.ToDouble(Valor2.Text); 
                double tiempo = Convert.ToDouble(Valor1.Text);    

                
                double distancia = velocidad * tiempo;

                
                Valor3.Text = distancia.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void Limpiar_Click(object sender, EventArgs e)
        {
            Valor1.Clear(); 
            Valor2.Clear(); 
            Valor3.Clear(); 
        }


        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}