using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using WS_Vista_Clases.Models;
using WS_Vista_Proc;
using WS_Vista_Proc.WS_Negocios;

namespace WS_Vista_Web
{
    public partial class About : Page
    {

        Relacionamiento Relacionamiento = new Relacionamiento();
        protected void Page_Load(object sender, EventArgs e)
        {
            //GridView1.SelectedIndex = -1;
            //GridView1.Visible = true;
            //GridView1.DataSource =Relacionamiento.Mostrar() ;
            //GridView1.DataBind();
        }

        protected void BTBuscar_Click(object sender, EventArgs e)//Buscar falta
        {
            
            var datos = Relacionamiento.Buscar(Convert.ToInt32(ID));
            
            
        }

        protected void BtGuardar_Click(object sender, EventArgs e)//Guardar
        {

            Usuario personas = new Usuario();

            personas.id =0;
            personas.ID_Usuario =Convert.ToInt32(ID_Usuario.Text);
            personas.Nombre =Nombre.Text;
            personas.Apellidos =Apellidos.Text;
            personas.Correo = Correo.Text;
            personas.telefono =Telefono.Text;

            
            string datos = Relacionamiento.Insert(personas);
            Limpiar();
        }

        protected void BtModificar_Click(object sender, EventArgs e)//Modificar
        {
            Usuario personas = new Usuario();

            personas.id = Convert.ToInt32(ID.Text);
            personas.ID_Usuario = Convert.ToInt32(ID_Usuario.Text);
            personas.Nombre = Nombre.Text;
            personas.Apellidos = Apellidos.Text;
            personas.Correo = Correo.Text;
            personas.telefono = Telefono.Text;

            string datos = Relacionamiento.Modificar(personas);
            Limpiar();
        }

        protected void BTEliminar_Click(object sender, EventArgs e)//Eliminar
        {
            string datos = Relacionamiento.Eliminar(Convert.ToInt32(ID.Text));
            Limpiar();
        }

        protected void BTLimpiar_Click(object sender, EventArgs e)//Limpiar
        {
            
            Limpiar();
        }

        public void Limpiar()
        {
            ID.Text = "";
            ID_Usuario.Text = "";
            Nombre.Text = "";
            Apellidos.Text = "";
            Telefono.Text = "";

        }
    }
}