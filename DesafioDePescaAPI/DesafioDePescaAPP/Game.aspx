<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="Game.aspx.cs" Inherits="DesafioDePescaAPP.Game" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Desafío de Pesca</title>
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
            max-width: 700px;
            margin: 50px auto;
            padding: 20px;
            background-color: #1c3b57;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
        }

        .game-info {
            margin: 20px 0;
            padding: 10px;
            background-color: #ffffff;
            color: #031926;
            border-radius: 5px;
        }

        .game-board table {
            width: 100%;
            border-collapse: collapse;
        }

        .game-board td {
            padding: 10px;
            text-align: center;
        }

        .game-button {
            width: 100%;
            padding: 15px;
            font-size: 18px;
            background-color: #303192;
            color: #ffffff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .game-button:hover {
            background-color: #5053ba;
        }

        .game-action-buttons {
            margin-top: 20px;
        }

        .game-action-buttons button {
            padding: 15px;
            font-size: 18px;
            background-color: #303192;
            color: #ffffff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            width: 100%;
            transition: background-color 0.3s ease;
        }

        .game-action-buttons button:hover {
            background-color: #5053ba;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="game-container">
            <h1>Desafío de Pesca</h1>
            <div class="game-board">
                <table>
                    <asp:Repeater ID="rpTablero" runat="server">
                        <ItemTemplate>
                            <%# (Container.ItemIndex % 10 == 0) ? "<tr>" : "" %>
                            <td>
                                <asp:Button ID="btnCasilla" runat="server" Text='<%# Container.DataItem %>'
                                    CssClass="game-button" CommandArgument='<%# Container.DataItem %>' OnCommand="Boton_Command" />
                            </td>
                            <%# (Container.ItemIndex % 10 == 9) ? "</tr>" : "" %>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
            <div class="game-info">
                <p>Intentos: <asp:Label ID="lblIntentos" runat="server" Text="0"></asp:Label></p>
                <p>Puntaje: <asp:Label ID="lblPuntaje" runat="server" Text="0"></asp:Label></p>
                <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>

            <div class="game-action-buttons">
                <asp:Button ID="btnReiniciar" runat="server" Text="Reiniciar Juego" OnClick="ReiniciarJuego_Click" />
                <asp:Button ID="btnTerminar" runat="server" Text="Terminar Juego" OnClick="TerminarJuego_Click" Visible="false" />
                <asp:Button ID="btnMostrarResultados" runat="server" Text="Mostrar Resultados" OnClick="MostrarResultados_Click" />
            </div>
        </div>
    </form>
</body>
</html>