<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MatrizNxN.aspx.cs" Inherits="Laboratorio202.MatrizNxN" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Matriz N x N</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Generar Matriz N x N</h2>
            <asp:TextBox ID="txtDimension" runat="server" placeholder="Ingrese la dimensión N"></asp:TextBox>
            <asp:Button ID="btnGenerarMatriz" runat="server" Text="Generar" OnClick="btnGenerarMatriz_Click" />
            <br /><br />
            <asp:Literal ID="ltMatriz" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
