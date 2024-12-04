<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="Login.aspx.cs" Inherits="DesafioDePescaAPP.Login" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Login - Desafío de Pesca</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #031926;
            color: #ffffff;
            text-align: center;
            margin: 0;
            padding: 0;
        }

        .game-container {
            max-width: 400px;
            margin: 50px auto;
            padding: 20px;
            background-color: #1c3b57;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
        }

        .game-info {
            margin: 20px 0;
            padding: 10px;
        }

        .form-label {
            display: block;
            margin-bottom: 10px;
            font-size: 16px;
        }

        .form-input {
            width: 100%;
            padding: 10px;
            font-size: 16px;
            margin-bottom: 20px;
            border: none;
            border-radius: 5px;
        }

        .form-button {
            width: 100%;
            padding: 10px;
            font-size: 16px;
            background-color: #303192;
            color: #ffffff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .form-button:hover {
            background-color: #5053ba;
        }

        .error-message {
            color: red;
            font-size: 14px;
            margin-top: 10px;
        }

        h1 {
            margin-bottom: 20px;
        }

        h2 {
            margin-top: 30px;
            font-size: 20px;
        }

        .game-info {
            padding: 20px;
        }

        /* For better alignment of inputs and buttons */
        .game-info input,
        .game-info button {
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="game-container">
            <h1>Desafío de Pesca - Login</h1>
            
            <!-- Login Section -->
            <div class="game-info">
                <asp:Label ID="lblCorreo" runat="server" Text="Correo:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtCorreoLogin" runat="server" CssClass="form-input" Placeholder="Ingresa tu correo" />
                <br />
                <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" CssClass="form-button" OnClick="btnLogin_Click" />
                <asp:Label ID="lblMessage" runat="server" CssClass="error-message"></asp:Label>
            </div>

            <!-- Registration Section -->
            <div class="game-info">
                <h2>¿Nuevo aquí? Regístrate</h2>
                <asp:Label ID="lblNombre" runat="server" Text="Nombre:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-input" Placeholder="Ingresa tu nombre" />
                <asp:Label ID="lblCorreoRegistro" runat="server" Text="Correo:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtCorreoRegistro" runat="server" CssClass="form-input" Placeholder="Ingresa tu correo" />
                <asp:Button ID="btnRegister" runat="server" Text="Registrar" CssClass="form-button" OnClick="btnRegister_Click" />
            </div>
        </div>
    </form>
</body>
</html>