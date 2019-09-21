using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Practica2_AYDS1
{
    public partial class AddProveedor : System.Web.UI.Page
    {
        string cadena = "data source=DESKTOP-K27HD4T\\SQLEXPRESS;initial catalog=Taller;integrated security=True;";
        SqlConnection con = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarProveedores();
        }

        protected void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cadena);
                con.Open();

                SqlCommand cmd = new SqlCommand("CrearProveedor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.ExecuteNonQuery();

                Limpiar();
                lblSucces.Text = "Proveedor agregado exitosamente.";

                mostrarProveedores();
            }
            catch (Exception ex) { lblError.Text = ex.Message; }
            finally { con.Close(); }

        }

        protected void mostrarProveedores()
        {
            try
            {
                lblError.Text = "";
                DataSet datos = getProeveedores();
                if (datos.Tables[0].Rows.Count == 0) GVclientes.DataSource = null;
                else GVclientes.DataSource = datos;

                GVclientes.DataBind();
            }
            catch (Exception ex) { lblError.Text = ex.Message; }
        }


        private DataSet getProeveedores()
        {
            try
            {
                DataSet lista = new DataSet();
                con = new SqlConnection(cadena);
                con.Open();

                SqlCommand cmd = new SqlCommand("ListarProveedores", con);
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
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

    }
}