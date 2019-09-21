<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ADDCarro.aspx.cs" Inherits="Practica2_AYDS1.ADDCarro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style2 {
            margin-left: 79px;
        }
        .auto-style1 {
            width: 193px;
        }
        .auto-style3 {
            margin-left: 83px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div>
            <asp:HiddenField ID="HFUsuario" runat="server" />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Placa"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPlaca" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Motor"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMotor" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Color"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtColor" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label7" runat="server" Text="Modelo"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtModelo" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Text="Año"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAnio" runat="server" Width="170px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server" Text="Marca"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMarca" runat="server" TextMode="Phone" Width="170px" Height="22px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label6" runat="server" Text="Dueño"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDuenio" runat="server" TextMode="Phone" Width="170px" Height="22px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                    </td>
                    <td>
                        <asp:Button ID="btnAgregarCarro" runat="server" Text="Agregar" OnClick="btnAgregaCarro_Click" Width="119px" />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                    </td>
                    <td>
                       <asp:Label ID="lblSucces" runat="server" Text="" ForeColor="Green"></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style1">
                    </td>
                    <td>
                        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </td>
                </tr>

            </table>

        </div>

    <div>

        <br />

        <br />
        <asp:GridView ID="GVCarros" runat="server" CssClass="auto-style3" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" EmptyDataText="No hay clientes">
            <Columns>
                <asp:BoundField HeaderText="Placa" DataField="Placa" />
                <asp:BoundField HeaderText="Motor" DataField="Motor" />
                <asp:BoundField HeaderText="Color" DataField="Color" />
                <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                <asp:BoundField HeaderText="Año" DataField="Año" />
                <asp:BoundField HeaderText="Marca" DataField="Marca" />
                <asp:BoundField HeaderText="Dueño" DataField="Dueño" />

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
        </div>
    </form>
</body>
</html>
