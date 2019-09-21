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
    public partial class AddFactura : System.Web.UI.Page
    {
        string cadena = "data source = HILBERTPC; initial catalog = Taller; integrated security = True;";
        public Coneccion coneccion;
        string errores;
        SqlConnection con = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            coneccion = new Coneccion();
            mostrarFacturas();

            coneccion.SetCadena(cadena);
        }

        protected void mostrarFacturas()
        {
            try
            {
                lblError.Text = "";
                DataSet datos = getFacturas();
                if (datos.Tables[0].Rows.Count == 0) GVCarros.DataSource = null;
                else GVCarros.DataSource = datos;

                GVCarros.DataBind();
            }
            catch (Exception ex) { lblError.Text = ex.Message; }
        }


        public DataSet getFacturas()
        {
            try
            {
                DataSet lista = new DataSet();
                con = new SqlConnection(cadena);
                con.Open();

                SqlCommand cmd = new SqlCommand("ListarFacturas", con);
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
            txtSerie.Text = "";
            txtNombre.Text = "";
            txtNo.Text = "";
            txtNit.Text = "";
            TxtDir.Text = "";

        }

        protected void btnAgregaFactura_Click(object sender, EventArgs e)
        {
            if (AgregarFactura(txtSerie.Text, Convert.ToInt32(txtNo.Text), txtNombre.Text, TxtDir.Text, txtNit.Text))
            {
                Limpiar();
                lblSucces.Text = "Factura agregada exitosamente.";

                mostrarFacturas();
            }
            else
            {
                lblError.Text = errores;
            }
        }

        public bool AgregarFactura(string serie,int numero,string nombre,string dir, string nit)
        {
            try
            {
                con = coneccion.conectar();


                SqlCommand cmd = new SqlCommand("CrearFactura", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serie ", serie );
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@dir", dir	);
                cmd.Parameters.AddWithValue("@nit", nit);
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