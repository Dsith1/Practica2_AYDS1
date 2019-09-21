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
    public partial class CrearRepuesto : System.Web.UI.Page
    {
        string cadena = "data source = HILBERTPC; initial catalog = Taller; integrated security = True;";
        SqlConnection con;
        public Coneccion coneccion;
        string errores;

        protected void Page_Load(object sender, EventArgs e)
        {
            coneccion = new Coneccion();
            Conexion(cadena);
        }
        public string Conexion(string cadenaConexion)
        {

            try
            {
                coneccion.SetCadena(cadenaConexion);
                con = coneccion.conectar();
                con.ToString();
                return "Correcto";
            }
            catch (Exception e)
            {
                return "INCorrecto";
            }
           
            
        }
        protected void IngresarRepuesto(object sender, EventArgs e)
        {
          if(  IngresarRepuestoM(TextBox1.Text, TextBox2.Text, Convert.ToInt32(TextBox3.Text), TextBox4.Text))
            {
                Console.WriteLine("Exito");
            }
            else
            {
                Console.WriteLine("Error al Ingresar repesto de carro: ", errores);
            }

            Limpiar();
            con.Close();
        }

        public bool IngresarRepuestoM(string parte,string carrorep, int anio,string existencias)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("dbo.CrearRepuesto", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@parteRep", parte);
                cmd.Parameters.AddWithValue("@carroRep", carrorep);
                cmd.Parameters.AddWithValue("@añoRep", anio);
                cmd.Parameters.AddWithValue("@existenciasRep", existencias);
                cmd.ExecuteNonQuery();

                return true;
            }

            catch (Exception ex)
            {

                errores = ex.Message;
                return false;
            }
            finally
            {
               
               
            }
        }
        protected void Limpiar()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
}