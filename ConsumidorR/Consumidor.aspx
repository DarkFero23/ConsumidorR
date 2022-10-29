<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consumidor.aspx.cs" Inherits="ConsumidorR.Consumidor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Consumidor de Web Services desde Visual Basic</h1>
            <asp:Label ID="lblNumero1" Text="Numero 1:" runat="server" />
            <asp:TextBox ID="txtNumero1" runat="server" />
             <hr />
            <asp:Label ID="lblNumero2" Text="Numero 2:" runat="server" />
            <asp:TextBox ID="txtNumero2" runat="server" />
             <hr />
             <asp:Button ID="BtnSumar" runat="server" Text="Sumar" OnClick="BtnSumar_Click" />

             <hr />
            <hr />
             <asp:Button ID="BtnResta" runat="server" Text="Resta" OnClick="BtnResta_Click" />

             <hr />
            <hr />
             <asp:Button ID="BtnMultiplicacion" runat="server" Text="Multi" OnClick="BtnMultiplicacion_Click" />

             <hr />
            <hr />
             <asp:Button ID="BtnDivision" runat="server" Text="Division" OnClick="BtnDivision_Click" />

             <hr />
            <asp:Label ID="LblResultado" Text="Resultdo" runat="server" />
        </div>
    </form>
</body>
</html>
