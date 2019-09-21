using System;
using System.Collections;
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
        public Boolean Conexion(string cadenaConexion)
        {
            try
            {
                con = new SqlConnection(cadena);
                con.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
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
            ArrayList values = new ArrayList();
            values.Add(TextBox1.Text);
            values.Add(TextBox2.Text);
            values.Add(TextBox3.Text);
            values.Add(TextBox4.Text);
            values.Add(TextBox5.Text);
            values.Add(TextBox6.Text);
            IngresoDB(values);
        }

        public Boolean IngresoDB(ArrayList values) {
            try
            {
                SqlCommand cmd = new SqlCommand("dbo.CrearPlanilla", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DPI", values[0]);
                cmd.Parameters.AddWithValue("@Nombre1", values[1]);
                cmd.Parameters.AddWithValue("@Nombre2", values[2]);
                cmd.Parameters.AddWithValue("@Apellido1", values[3]);
                cmd.Parameters.AddWithValue("@Apellido2", values[4]);
                cmd.Parameters.AddWithValue("@Salario", Convert.ToInt32(values[5]));
                cmd.ExecuteNonQuery();
                con.Close();
                Limpiar();
                Console.WriteLine("Hello World");
                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error al Ingresar Empleado: ", ex.Message);
                return false;
            }
        }
    }
}