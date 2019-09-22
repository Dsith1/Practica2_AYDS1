using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica2_AYDS1
{
    public partial class AddEntrega : System.Web.UI.Page
    {
        string cadena = "data source = HILBERTPC; initial catalog = Taller; integrated security = True;";
        public Coneccion coneccion;
        string errores;
        SqlConnection con = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            coneccion = new Coneccion();
            mostrarEntregas();

            coneccion.SetCadena(cadena);
        }

        protected void mostrarEntregas()
        {
            try
            {
                lblError.Text = "";
                DataSet datos = getEntregas();
                if (datos.Tables[0].Rows.Count == 0) GVCarros.DataSource = null;
                else GVCarros.DataSource = datos;

                GVCarros.DataBind();
            }
            catch (Exception ex) { lblError.Text = ex.Message; }
        }


        public DataSet getEntregas()
        {
            try
            {
                DataSet lista = new DataSet();
                con = new SqlConnection(cadena);
                con.Open();

                SqlCommand cmd = new SqlCommand("ListarEntregas", con);
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
            txtcarror.Text = "";


        }

        protected void btnAgregaEntrega_Click(object sender, EventArgs e)
        {

            if (Agregar_Carro(Convert.ToInt32(txtcarror.Text)))
            {
                Limpiar();
                lblSucces.Text = "Entrega agregada exitosamente.";

                mostrarEntregas();
            }
            else
            {
                lblError.Text = errores;
            }

        }

        public bool Agregar_Carro( int carro)
        {
            try
            {
                con = coneccion.conectar();


                SqlCommand cmd = new SqlCommand("CrearEntregaBeta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@carro", carro);

                cmd.ExecuteNonQuery();


                return true;
            }
            catch (Exception ex)
            {
                errores = ex.Message;
                return false;
            }
        }
    }
}