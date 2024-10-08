using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12_2
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
                
                double Nota1 = Convert.ToDouble(Valor1.Text); 
                double Nota2 = Convert.ToDouble(Valor2.Text); 
                double Nota3 = Convert.ToDouble(Valor3.Text); 

               
                double Promedio = (Nota1 + Nota2 + Nota3) / 3;

                
                ValorFinal.Text = Promedio.ToString("F2"); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        private void Reset_Click(object sender, EventArgs e)
        {
            
            Valor1.Clear();
            Valor2.Clear();
            Valor3.Clear();
            ValorFinal.Clear();
        }

        
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}