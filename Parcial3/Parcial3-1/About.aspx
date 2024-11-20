<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Parcial3_1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registrar Juego de Lotería</h2>
    <form id="formLoteria" runat="server">
        <div>
            <label for="txtNombreJuego">Nombre del Juego:</label>
            <asp:TextBox ID="txtNombreJuego" runat="server" placeholder="Nombre del Juego"></asp:TextBox>
        </div>
        <div>
            <label for="txtFechaJuego">Fecha del Juego:</label>
            <asp:TextBox ID="txtFechaJuego" runat="server" placeholder="YYYY-MM-DD"></asp:TextBox>
        </div>
        <div>
            <label for="txtCiudadJuego">Ciudad:</label>
            <asp:TextBox ID="txtCiudadJuego" runat="server" placeholder="Ciudad"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar Juego" OnClick="btnRegistrar_Click" />
        </div>
        <div>
            <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Green"></asp:Label>
        </div>
    </form>
</asp:Content>
