using System;
using System.Web.UI;

namespace Lab_154
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
      
            double num1, num2, resultado;

            if (double.TryParse(txtNum1.Text, out num1) && double.TryParse(txtNum2.Text, out num2))
            {
                resultado = num1 + num2;

                
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                // Mostrar un mensaje de error si la conversión falla
                txtResultado.Text = "Error: Ingrese números válidos.";
            }
        }

        protected void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
