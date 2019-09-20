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
        string cadena = "Data Source=HILBERTPC;Initial Catalog=Taller; Integrated Security=True";
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            Conexion(cadena);
        }
        protected void Conexion(string cadenaConexion)
        {
            con = new SqlConnection(cadena);
            con.Open();
        }
        protected void IngresarRepuesto(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("dbo.CrearRepuesto", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@parteRep", TextBox1.Text);
                cmd.Parameters.AddWithValue("@carroRep", TextBox2.Text);
                cmd.Parameters.AddWithValue("@añoRep", Convert.ToInt32(TextBox3.Text));
                cmd.Parameters.AddWithValue("@existenciasRep", TextBox4.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Limpiar();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error al Ingresar repesto: ", ex.Message);
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