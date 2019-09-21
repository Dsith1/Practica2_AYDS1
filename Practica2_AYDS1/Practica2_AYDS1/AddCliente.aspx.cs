﻿using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Web_Practica2_AYD1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string cadena = "data source=DESKTOP-K27HD4T\\SQLEXPRESS;initial catalog=Taller;integrated security=True;";
        SqlConnection con = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        protected void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cadena);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.CrearCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre1", txtNombre1.Text);
                cmd.Parameters.AddWithValue("@Nombr2", txtNombre2.Text);
                cmd.Parameters.AddWithValue("@Apellido1", txtApellido1.Text);
                cmd.Parameters.AddWithValue("@Apellido2", txtApellido2.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.ExecuteNonQuery();

                Limpiar();
            }
            catch (Exception ex) { throw ex; }
            finally { con.Close(); }

        }

        protected void mostrarClientes()
        {
            try
            {
                lblError.Text = "";
                DataSet datos = getClientes();
                if(datos.Tables[0].Rows.Count == 0)  GVclientes.DataSource = null; 
                else GVclientes.DataSource = datos;

                GVclientes.DataBind();
            }
            catch(Exception ex) { lblError.Text = ex.Message; }
        }


        private DataSet getClientes()
        {
            try
            {
                DataSet lista = new DataSet();
                con = new SqlConnection(cadena);
                con.Open();

                SqlCommand cmd = new SqlCommand("ListarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                sqlData.Fill(lista);

                return lista;
            }
            catch (Exception ex) { throw ex; }
            finally { con.Close(); }

        }

        protected void Limpiar()
        {
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtNombre1.Text = "";
            txtNombre2.Text = "";
            txtTelefono.Text = "";
        }

    }
}