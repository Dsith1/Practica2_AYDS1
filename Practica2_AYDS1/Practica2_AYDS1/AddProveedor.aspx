<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProveedor.aspx.cs" Inherits="Practica2_AYDS1.AddProveedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Nuevo Proveedor</title>
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
            <asp:HiddenField ID="HFProveedor" runat="server" />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtNombre" runat="server" Width="170px"></asp:TextBox>
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
                        <asp:Button ID="btnAgregarProveedor" runat="server" Text="Agregar" OnClick="btnAgregarProveedor_Click" Width="119px" />
                        <br />
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
        <asp:GridView ID="GVclientes" runat="server" CssClass="auto-style3" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" EmptyDataText="No hay Proveedores">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="id_proveedor" />
                <asp:BoundField HeaderText="Nombre" DataField="nombre" />
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

