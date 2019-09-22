<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Planilla.aspx.cs" Inherits="Practica2_AYDS1.Planilla" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        PLANILLA</h2>
    <div class="form-group">
            <asp:Label runat="server" ID="Label1" CssClass="col-md-2 control-label">DPI</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBox1" CssClass="form-control" Width="200" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" ID="Label2" CssClass="col-md-2 control-label">Primer Nombre</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBox2" CssClass="form-control" Width="200" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" ID="Label3" CssClass="col-md-2 control-label">Segundo Nombre</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBox3" CssClass="form-control" Width="200"/>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" ID="Label4" CssClass="col-md-2 control-label">Primer Apellido</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBox4" CssClass="form-control" Width="200" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" ID="Label6" CssClass="col-md-2 control-label">Primer Apellido</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBox5" CssClass="form-control" Width="200" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" ID="Label5" CssClass="col-md-2 control-label">Salario</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBox6" CssClass="form-control" Width="200" />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-10">
                <asp:Button runat="server" OnClick="IngresarEmpleado" Text="Ingresar Empleado" CssClass="btn btn-default" BorderColor="#0000cc"/>
            </div>
        </div>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_empleado" DataSourceID="SqlDataSourceSG">
            <Columns>
                <asp:BoundField DataField="id_empleado" HeaderText="id_empleado" InsertVisible="False" ReadOnly="True" SortExpression="id_empleado" />
                <asp:BoundField DataField="DPI" HeaderText="DPI" SortExpression="DPI" />
                <asp:BoundField DataField="Nombre1" HeaderText="Nombre1" SortExpression="Nombre1" />
                <asp:BoundField DataField="Nombr2" HeaderText="Nombr2" SortExpression="Nombr2" />
                <asp:BoundField DataField="Apellido1" HeaderText="Apellido1" SortExpression="Apellido1" />
                <asp:BoundField DataField="Apellido2" HeaderText="Apellido2" SortExpression="Apellido2" />
                <asp:BoundField DataField="Salario" HeaderText="Salario" SortExpression="Salario" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceSG" runat="server" ConnectionString="<%$ ConnectionStrings:TallerConnectionString2 %>" SelectCommand="SELECT * FROM [Planilla]"></asp:SqlDataSource>

</asp:Content>
