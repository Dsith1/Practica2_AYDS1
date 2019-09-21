<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Practica2_AYDS1.CrearRepuesto" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="jumbotron">
        <h1>TALLER</h1>
        <p class="lead">Un sistema en el cual podrá hacer las gestiones que un taller necesita como el de ingresar cliente, ingresar un proveedor, gestionar las facturas y demas procesos que sean necesarios dentro del taller.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Repuestos</h2>
            <p class="lead">¡LA MEJOR CALIDAD ACÁ!</p>
            <p>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/repuestos.jpg" Height="157px" Width="272px" />
            </p>
           
        </div>
        <div class="col-md-4">
            <h2>ATENCION AL CLIENTE</h2>
             <p class="lead">Un excelente atencion a nuestros clientes</p>
            <p>
               <asp:Image ID="Image2" runat="server" ImageUrl="~/Imagenes/atencion.jpg" Height="157px" Width="214px" />
            </p>
            
        </div>
        <div class="col-md-4">
            <h2>CONTROL DE EMPLEADOS</h2>
            <p class="lead">Diversidad de equipos para la atencion de su vehiculo</p>
            <p>
                <asp:Image ID="Image3" runat="server" ImageUrl="~/Imagenes/arreglando.jpg" Height="157px" Width="286px" />
            </p>
            
        </div>
    </div>

</asp:Content>
