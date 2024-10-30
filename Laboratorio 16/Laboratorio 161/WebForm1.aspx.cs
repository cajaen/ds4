using System;
using System.Web.UI;

namespace Laboratorio_161
{
    public partial class WebForm1 : Page
    {
        private double valor1 = 0;
        private string operador = "";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            T.Text += "1";
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            T.Text += "2";
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            T.Text += "3";
        }

        protected void add_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(T.Text);
            operador = "+";
            T.Text = "";
        }

        protected void b4_Click(object sender, EventArgs e)
        {
            T.Text += "4";
        }

        protected void b5_Click(object sender, EventArgs e)
        {
            T.Text += "5";
        }

        protected void b6_Click(object sender, EventArgs e)
        {
            T.Text += "6";
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(T.Text);
            operador = "-";
            T.Text = "";
        }

        protected void b7_Click(object sender, EventArgs e)
        {
            T.Text += "7";
        }

        protected void b8_Click(object sender, EventArgs e)
        {
            T.Text += "8";
        }

        protected void b9_Click(object sender, EventArgs e)
        {
            T.Text += "9";
        }

        protected void mul_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(T.Text);
            operador = "*";
            T.Text = "";
        }

        protected void b0_Click(object sender, EventArgs e)
        {
            T.Text += "0";
        }

        protected void clr_Click(object sender, EventArgs e)
        {
            T.Text = "";
            valor1 = 0;
            operador = "";
        }

        protected void eq_Click(object sender, EventArgs e)
        {
            double valor2 = double.Parse(T.Text);
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    break;
            }

            T.Text = resultado.ToString();
        }

        protected void div_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(T.Text);
            operador = "/";
            T.Text = "";
        }
    }
}

