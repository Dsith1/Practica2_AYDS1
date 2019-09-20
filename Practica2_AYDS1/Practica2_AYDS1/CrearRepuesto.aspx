<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CrearRepuesto.aspx.cs" Inherits="Practica2_AYDS1.CrearRepuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<body>
    <h2>
        PRACTICA 2
    </h2>
    <form id="form1" runat="server">
        <div class="form-group">
            <asp:Label runat="server" ID="Label1" CssClass="col-md-2 control-label">Parte</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBox1" CssClass="form-control" Width="200" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" ID="Label2" CssClass="col-md-2 control-label">Carro</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBox2" CssClass="form-control" Width="200" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" ID="Label3" CssClass="col-md-2 control-label">Año</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBox3" CssClass="form-control" Width="200"/>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" ID="Label4" CssClass="col-md-2 control-label">Existencias</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBox4" CssClass="form-control" Width="200" />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-10">
                <asp:Button runat="server" OnClick="IngresarRepuesto" Text="Ingresar Repuesto" CssClass="btn btn-default" BorderColor="#0000cc"/>
            </div>
        </div>
        <div>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_repuesto" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="id_repuesto" HeaderText="id_repuesto" InsertVisible="False" ReadOnly="True" SortExpression="id_repuesto" />
                    <asp:BoundField DataField="parte" HeaderText="parte" SortExpression="parte" />
                    <asp:BoundField DataField="carro" HeaderText="carro" SortExpression="carro" />
                    <asp:BoundField DataField="año" HeaderText="año" SortExpression="año" />
                    <asp:BoundField DataField="existencias" HeaderText="existencias" SortExpression="existencias" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:TallerConexion %>" DeleteCommand="DELETE FROM [Repuesto] WHERE [id_repuesto] = @original_id_repuesto AND [parte] = @original_parte AND [carro] = @original_carro AND [año] = @original_año AND (([existencias] = @original_existencias) OR ([existencias] IS NULL AND @original_existencias IS NULL))" InsertCommand="INSERT INTO [Repuesto] ([parte], [carro], [año], [existencias]) VALUES (@parte, @carro, @año, @existencias)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Repuesto]" UpdateCommand="UPDATE [Repuesto] SET [parte] = @parte, [carro] = @carro, [año] = @año, [existencias] = @existencias WHERE [id_repuesto] = @original_id_repuesto AND [parte] = @original_parte AND [carro] = @original_carro AND [año] = @original_año AND (([existencias] = @original_existencias) OR ([existencias] IS NULL AND @original_existencias IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_id_repuesto" Type="Int32" />
                    <asp:Parameter Name="original_parte" Type="String" />
                    <asp:Parameter Name="original_carro" Type="String" />
                    <asp:Parameter Name="original_año" Type="Int32" />
                    <asp:Parameter Name="original_existencias" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="parte" Type="String" />
                    <asp:Parameter Name="carro" Type="String" />
                    <asp:Parameter Name="año" Type="Int32" />
                    <asp:Parameter Name="existencias" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="parte" Type="String" />
                    <asp:Parameter Name="carro" Type="String" />
                    <asp:Parameter Name="año" Type="Int32" />
                    <asp:Parameter Name="existencias" Type="Int32" />
                    <asp:Parameter Name="original_id_repuesto" Type="Int32" />
                    <asp:Parameter Name="original_parte" Type="String" />
                    <asp:Parameter Name="original_carro" Type="String" />
                    <asp:Parameter Name="original_año" Type="Int32" />
                    <asp:Parameter Name="original_existencias" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>

        </div>
    </form>
</body>
    
</asp:Content>
