<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TablaMultiplicar.aspx.cs" Inherits="Laboratorio201.TablaMultiplicar" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tabla de Multiplicar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Generar Tabla de Multiplicar</h2>
            <asp:TextBox ID="txtNumero" runat="server" placeholder="Ingrese un número"></asp:TextBox>
            <asp:Button ID="btnGenerar" runat="server" Text="Generar" OnClick="btnGenerar_Click" />
            <br /><br />
            <asp:Literal ID="ltResultado" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>

