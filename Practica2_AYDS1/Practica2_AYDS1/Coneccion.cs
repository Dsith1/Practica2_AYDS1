using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Practica2_AYDS1
{
    public class Coneccion
    {
        string cadena;
       
        public string resultado;
        public SqlConnection con = null;

        public void SetCadena(string cad)
        {
            cadena = cad;

            resultado = "hola soy " + cad;
        }

        public SqlConnection conectar()
        {
            

            try
            {
                con = new SqlConnection(cadena);
                con.Open();
            }
            catch (Exception ex)
            {
                con = null;
            }

            return con;

            
            
        }

        public SqlConnection desconectar()
        {
            try
            {
                con.Close();
            }catch(Exception ex)
            {
                con = null;
            }
            

            return con;



        }

    }
}