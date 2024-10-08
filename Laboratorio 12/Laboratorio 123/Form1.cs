using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Calcular_SP_Click(object sender, EventArgs e)
        {
            try
            {
                
                double a = Convert.ToDouble(LA.Text); 
                double b = Convert.ToDouble(LB.Text); 
                double c = Convert.ToDouble(LC.Text); 

                
                double semiperimetro = (a + b + c) / 2;

                
                SP.Text = semiperimetro.ToString("F2"); 
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

        
        private void Calcular_Area_Click(object sender, EventArgs e)
        {
            try
            {
               
                double a = Convert.ToDouble(LA.Text); 
                double b = Convert.ToDouble(LB.Text); 
                double c = Convert.ToDouble(LC.Text); 
                double semiperimetro = Convert.ToDouble(SP.Text); 

                
                double area = Math.Sqrt(semiperimetro * (semiperimetro - a) * (semiperimetro - b) * (semiperimetro - c));

                
                A.Text = area.ToString("F2"); 
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
            LA.Clear();
            LB.Clear();
            LC.Clear();
            SP.Clear();
            A.Clear();
        }

        
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void LA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}