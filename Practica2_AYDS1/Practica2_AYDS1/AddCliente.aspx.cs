using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Practica2_AYDS1;

namespace Web_Practica2_AYD1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        Coneccion coneccion;
        

        public void Page_Load(object sender, EventArgs e)
        {
            coneccion.SetCadena("data source = DESKTOP - K27HD4T\\SQLEXPRESS; initial catalog = Taller; integrated security = True;");

            mostrarClientes();

        }

        public void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            AgregarCliente(txtNombre1.Text, txtNombre2.Text, txtApellido1.Text, txtApellido2.Text, txtTelefono.Text);
        }

        public void AgregarCliente(string nombre1, string nombre2, string apellido1, string apellido2, string telefono)
        {
            SqlConnection con = coneccion.conectar();
            try
            {


                SqlCommand cmd = new SqlCommand("dbo.CrearCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre1", nombre1);
                cmd.Parameters.AddWithValue("@Nombr2", nombre2);
                cmd.Parameters.AddWithValue("@Apellido1", apellido1);
                cmd.Parameters.AddWithValue("@Apellido2", apellido2);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.ExecuteNonQuery();

                Limpiar();
                lblSucces.Text = "Cliente agregado exitosamente.";

                mostrarClientes();
            }
            catch (Exception ex) { lblError.Text = ex.Message; }
            finally
            {
                coneccion.desconectar();
            }
        }

        public void mostrarClientes()
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


        public DataSet getClientes()
        {
            SqlConnection con = coneccion.conectar();
            try
            {
                DataSet lista = new DataSet();

                SqlCommand cmd = new SqlCommand("ListarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                sqlData.Fill(lista);

                return lista;
            }
            catch (Exception ex) { throw ex;
                return null;
            }
            finally { con.Close();
                
            }

        }

        public void Limpiar()
        {
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtNombre1.Text = "";
            txtNombre2.Text = "";
            txtTelefono.Text = "";
        }

    }
}