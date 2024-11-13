<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProductos.aspx.cs" Inherits="Laboratorio203.frmProductos" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Productos</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }

        .container {
            width: 60%;
            margin: 20px auto;
            border: 1px solid #ccc;
            border-radius: 5px;
            padding: 20px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        .header {
            display: flex;
            align-items: center;
            justify-content: space-between;
            margin-bottom: 20px;
        }

        .header h2 {
            margin: 0;
        }

        .buttons {
            display: flex;
            gap: 10px;
        }

        label {
            font-weight: bold;
            display: block;
            margin-bottom: 5px;
        }

        input[type="text"] {
            width: calc(100% - 10px);
            padding: 5px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 3px;
        }

        .form-row {
            display: flex;
            gap: 20px;
            align-items: center;
        }

        .form-row div {
            flex: 1;
        }

        .search-row {
            display: flex;
            align-items: center;
            gap: 10px;
            margin-bottom: 20px;
        }

        .search-row input {
            flex: 1;
        }

        .footer {
            text-align: center;
        }

        .footer button {
            background-color: #f44336;
            color: white;
            border: none;
            padding: 10px 20px;
            border-radius: 3px;
            cursor: pointer;
        }

        .footer button:hover {
            background-color: #d32f2f;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <h2>Gestión de Productos</h2>
                <div class="buttons">
                    <asp:Button ID="btnNuevo" runat="server" Text="+" OnClick="btnNuevo_Click" />
                    <asp:Button ID="btnGuardar" runat="server" Text="💾" OnClick="btnGuardar_Click" Enabled="false" />
                    <asp:Button ID="btnCancelar" runat="server" Text="✖" OnClick="btnCancelar_Click" Enabled="false" />
                    <asp:Button ID="btnEliminar" runat="server" Text="🗑" OnClick="btnEliminar_Click" Enabled="false" />
                </div>
            </div>

            <div class="search-row">
                <label for="txtBuscarId">Buscar por ID:</label>
                <asp:TextBox ID="txtBuscarId" runat="server" placeholder="Ingrese ID"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" Text="🔍" OnClick="btnBuscar_Click" />
            </div>

            <div class="form-row">
                <div>
                    <label for="txtId">ID:</label>
                    <asp:TextBox ID="txtId" runat="server" Enabled="false" />
                </div>
                <div>
                    <label for="txtNombre">Nombre:</label>
                    <asp:TextBox ID="txtNombre" runat="server" />
                </div>
            </div>

            <div class="form-row">
                <div>
                    <label for="txtPrecio">Precio:</label>
                    <asp:TextBox ID="txtPrecio" runat="server" />
                </div>
                <div>
                    <label for="txtStock">Stock:</label>
                    <asp:TextBox ID="txtStock" runat="server" />
                </div>
            </div>

            <div class="footer">
                <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" />
            </div>
        </div>
    </form>
</body>
</html>


