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
    public partial class ADDCarro : System.Web.UI.Page
    {
        string cadena = "data source = LAPTOP-IFGR27P8; initial catalog = Taller; integrated security = True;";
        public Coneccion coneccion;
        string errores;
        SqlConnection con = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            coneccion = new Coneccion();
            mostrarCarros();

            coneccion.SetCadena(cadena);
        }

        protected void mostrarCarros()
        {
            try
            {
                lblError.Text = "";
                DataSet datos = getCarros();
                if (datos.Tables[0].Rows.Count == 0) GVCarros.DataSource = null;
                else GVCarros.DataSource = datos;

                GVCarros.DataBind();
            }
            catch (Exception ex) { lblError.Text = ex.Message; }
        }


        public DataSet getCarros()
        {
            try
            {
                DataSet lista = new DataSet();
                con = new SqlConnection(cadena);
                con.Open();

                SqlCommand cmd = new SqlCommand("ListarCarros", con);
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
            txtPlaca.Text = "";
            txtMotor.Text = "";
            txtMarca.Text = "";
            txtDuenio.Text = "";
            txtColor.Text = "";
            txtAnio.Text = "";

        }

      

        protected void btnAgregaCarro_Click(object sender, EventArgs e)
        {

           if( Agregar_Carro(txtPlaca.Text,txtMotor.Text, txtColor.Text, TxtModelo.Text,Convert.ToInt32(txtAnio.Text), Convert.ToInt32(txtMarca.Text), Convert.ToInt32(txtDuenio.Text)))
            {
                Limpiar();
                lblSucces.Text = "Carro agregado exitosamente.";

                mostrarCarros();
            }
            else
            {
                lblError.Text = errores;
            }
        }

        public bool Agregar_Carro(string placa,string motor ,string color,string modelo, int año,int marca,int duenio)
        {
            try
            {
                con = coneccion.conectar();


                SqlCommand cmd = new SqlCommand("CrearCarro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@placa", placa);
                cmd.Parameters.AddWithValue("@motor",   motor  );
                cmd.Parameters.AddWithValue("@color",   color  );
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@año",     año    );
                cmd.Parameters.AddWithValue("@marca",   marca  );
                cmd.Parameters.AddWithValue("@duenio",duenio );
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