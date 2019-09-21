<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Practica2_AYDS1.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Agregar Cliente</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Agregar Proveedor</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Crear Repuesto</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Agregar Empleado</asp:LinkButton>
        </div>
    </form>
</body>
</html>
