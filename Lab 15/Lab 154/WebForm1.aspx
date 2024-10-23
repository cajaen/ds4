<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab_154.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Suma de Números</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <asp:Label ID="Label1" runat="server" Text="Suma de Números"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Introduzca un número"></asp:Label>
            <asp:TextBox ID="txtNum1" runat="server" OnTextChanged="txtNum1_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Introduzca otro número"></asp:Label>
            <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
        </p>
        <p>
            <asp:Label ID="LabelResultado" runat="server" Text="Resultado: "></asp:Label>
            <asp:TextBox ID="txtResultado" runat="server" ReadOnly="true"></asp:TextBox>
        </p>
    </form>
</body>
</html>

