using System;
namespace Laboratorio201
{
    public partial class TablaMultiplicar : System.Web.UI.Page
    {
        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(txtNumero.Text, out numero))
            {
                string resultado = "<table border='1'>";
                for (int i = 1; i <= 25; i++)
                {
                    resultado += $"<tr><td>{numero} x {i} = {numero * i}</td></tr>";
                }
                resultado += "</table>";
                ltResultado.Text = resultado;
            }
            else
            {
                ltResultado.Text = "Por favor, ingrese un número válido.";
            }
        }
    }
}
