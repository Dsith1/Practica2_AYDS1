<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddEntrega.aspx.cs" Inherits="Practica2_AYDS1.AddEntrega" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
        <div>
            <asp:HiddenField ID="HFUsuario" runat="server" />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Carro"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtcarror" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                    </td>
                    <td>
                        <asp:Button ID="btnAgregarEntrega" runat="server" Text="Agregar" OnClick="btnAgregaEntrega_Click" Width="119px" />
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
                <asp:BoundField HeaderText="Correlativo" DataField="Correlativo" />
                <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
                <asp:BoundField HeaderText="Carro" DataField="Carro" />

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
</asp:Content>