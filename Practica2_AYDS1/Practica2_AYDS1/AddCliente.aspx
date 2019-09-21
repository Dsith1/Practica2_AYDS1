<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web_Practica2_AYD1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 193px;
        }
        .auto-style2 {
            margin-left: 79px;
        }
        .auto-style3 {
            margin-left: 83px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="HFUsuario" runat="server" />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Primer Nombre"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtNombre1" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Segundo Nombre"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtNombre2" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Primer Apellido"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtApellido1" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Text="Segundo Apellido"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtApellido2" runat="server" Width="170px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server" Text="Telefono"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtTelefono" runat="server" TextMode="Phone" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                    </td>
                    <td colspan="2">
                        <asp:Button ID="btnAgregarCliente" runat="server" Text="Agregar" OnClick="btnAgregarCliente_Click" Width="119px" />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                    </td>
                    <td colspan="2">
                       <asp:Label ID="lblSucces" runat="server" Text="" ForeColor="Green"></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style1">
                    </td>
                    <td colspan="2">
                        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </td>
                </tr>

            </table>

        </div>

    <div>

        <br />

        <br />
        <asp:GridView ID="GVclientes" runat="server" CssClass="auto-style3" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" EmptyDataText="No hay clientes">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="id_usuario" />
                <asp:BoundField HeaderText="Primer Nombre" DataField="Nombre1" />
                <asp:BoundField HeaderText="Segundo Nombre" DataField="Nombr2" />
                <asp:BoundField HeaderText="Primer Apellido" DataField="Apellido1" />
                <asp:BoundField HeaderText="Segundo Apellido" DataField="Apellido2" />
                <asp:BoundField HeaderText="Telefono" DataField="telefono" />

            </Columns>

            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />

        </asp:GridView>

    </div>
    </form>

    </body>
</html>
