using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WS_Clases.Clases;
using WS_Datos_Proc;
using WS_Datos_Proc.Mante;

namespace WS_Datos
{
    /// <summary>
    /// Descripción breve de Datos
    /// </summary>
    //[WebService(Namespace = "http://tempuri.org/")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    //[System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Datos : System.Web.Services.WebService
    {
        Mantenimiento Mante = new Mantenimiento();

        //Insertar
        [WebMethod]
        public string insertar(Personas personas)
        {
            return Mante.insertar(personas);

        }
        ////Modificar
        [WebMethod]
        public string modificar(Personas personas)
        {
            return Mante.Modificar(personas);

        }
        ////Eliminar
        [WebMethod]
        public string Eliminar(int id)
        {
            return Mante.Eliminar(id);

        }

        //Modificar
        [WebMethod]
        public List<Personas> Mostrar()
        {
            return Mante.mostrar();

        }

        //Buscar
        [WebMethod]
        public List<Personas> Buscar(int id)
        {
            return Mante.Buscar(id);

        }

        ////Informe
        //[WebMethod]
        //public string insertar(Personas personas)
        //{
        //    return manteinimiento.Insertar(personas);

        //}
    }
}
