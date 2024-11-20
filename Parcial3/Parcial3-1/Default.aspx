<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Parcial3_1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <!-- GridView para mostrar datos -->
        <asp:GridView ID="MyGridView" 
                      DataSourceID="MyDataSource1" 
                      AllowSorting="True" 
                      AllowPaging="True" 
                      DataKeyNames="IDJuego"
                      AutoGenerateColumns="True" 
                      AutoGenerateEditButton="True"
                      Runat="Server"/>
        
        <!-- SqlDataSource para conectar la base de datos -->
        <asp:SqlDataSource ID="MyDataSource1" 
                           runat="server"
                           ConnectionString="data source=CARLOS0192\SQLEXPRESS;initial catalog=LoteriaNacional;persist security info=True;Integrated Security=SSPI;"
                           ProviderName="System.Data.SqlClient"
                           SelectCommand="SELECT IDJuego, FechaJuego, DiaJuego, Ciudad FROM JuegosLoteria"
                           UpdateCommand="UPDATE JuegosLoteria SET [FechaJuego]=@FechaJuego, [DiaJuego]=@DiaJuego, [Ciudad]=@Ciudad WHERE [IDJuego]=@IDJuego">
            <UpdateParameters>
                <asp:Parameter Name="FechaJuego" Type="DateTime" />
                <asp:Parameter Name="DiaJuego" Type="String" />
                <asp:Parameter Name="Ciudad" Type="String" />
                <asp:Parameter Name="IDJuego" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>

</asp:Content>

