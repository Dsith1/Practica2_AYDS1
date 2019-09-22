using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Practica2_AYDS1
{
    public partial class AddProveedor : System.Web.UI.Page
    {
        string cadena = "data source = HILBERTPC; initial catalog = Taller; integrated security = True;";
        public Coneccion coneccion;
        string errores;
        SqlConnection con = null;

        protected void Page_Load(object sender, EventArgs e)
        {

            coneccion = new Coneccion();
            mostrarProveedores();

            coneccion.SetCadena(cadena);
        }

        protected void btnAgregarProveedor_Click(object sender, EventArgs e)
        {

            if(AgregarProveedor(txtNombre.Text, txtTelefono.Text))
            {

                Limpiar();
                lblSucces.Text = "Proveedor agregado exitosamente.";

                mostrarProveedores();

            }
            else
            {
                lblError.Text = errores;
            }

            con.Close();
        }

        public bool AgregarProveedor(string nombre,string telefono)
        {
            try
            {
                con = coneccion.conectar();


                SqlCommand cmd = new SqlCommand("CrearProveedor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.ExecuteNonQuery();

                
                return true;
            }
            catch (Exception ex) { errores = ex.Message;
                return false;
            }
            finally {  }
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


        public DataSet getProeveedores()
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