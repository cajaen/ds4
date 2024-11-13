using System;
namespace Laboratorio202
{
    public partial class MatrizNxN : System.Web.UI.Page
    {
        protected void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtDimension.Text, out n) && n > 0)
            {
                string matrizHtml = "<table border='1'>";
                for (int i = 0; i < n; i++)
                {
                    matrizHtml += "<tr>";
                    for (int j = 0; j < n; j++)
                    {
                        if (j == n - i - 1)
                            matrizHtml += "<td>1</td>";
                        else
                            matrizHtml += "<td>0</td>";
                    }
                    matrizHtml += "</tr>";
                }
                matrizHtml += "</table>";
                ltMatriz.Text = matrizHtml;
            }
            else
            {
                ltMatriz.Text = "Ingrese una dimensión válida.";
            }
        }
    }
}
