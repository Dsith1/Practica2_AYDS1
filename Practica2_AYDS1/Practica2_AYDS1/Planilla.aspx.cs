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
    public partial class Planilla : System.Web.UI.Page
    {

        string cadena = "Data Source=SERGIO\\SERGIO;Initial Catalog=Taller; Integrated Security=True";
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
        protected void Limpiar()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void IngresarEmpleado(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("dbo.CrearPlanilla", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DPI", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Nombre1", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Nombre2", TextBox3.Text);
                cmd.Parameters.AddWithValue("@Apellido1", TextBox4.Text);
                cmd.Parameters.AddWithValue("@Apellido2", TextBox5.Text);
                cmd.Parameters.AddWithValue("@Salario", Convert.ToInt32(TextBox6.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                Limpiar();
                Console.WriteLine("Hello World");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error al Ingresar Empleado: ", ex.Message);
            }
        }
    }
}