using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica2_AYDS1
{
    public partial class Inicio : System.Web.UI.Page
    {
        public string a;
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        public void prueba()
        {
            a = "hola";
        }

        public void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCliente.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProveedor.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("CrearRepuesto.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Planilla.aspx");
        }
    }
}