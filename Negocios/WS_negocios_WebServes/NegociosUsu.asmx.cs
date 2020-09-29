using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WS_negocio_proc.Procedimientos;
using WS_Negocios.WS_Datos;
using WS_Negocios_clases.Clases;

namespace WS_negocios_WebServes
{
    ///// <summary>
    ///// Descripción breve de NegociosUsu
    ///// </summary>
    //[WebService(Namespace = "http://tempuri.org/")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    //[System.ComponentModel.ToolboxItem(false)]
    //// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    //// [System.Web.Script.Services.ScriptService]
    public class NegociosUsu : System.Web.Services.WebService
    {

        Conexiones_Procedimientos procesos = new Conexiones_Procedimientos();
        [WebMethod]
        public string Insertar(Usuario personas) { return procesos.Insertar(personas); }
        [WebMethod]
        public string Modificar(Usuario personas) { return procesos.Modificar(personas); }
        [WebMethod]
        public string Eliminar(int id) { return procesos.Eliminar(id); }
        [WebMethod]
        public List<Usuario> Buscar(int id) {  return procesos.Buscar(id); }
        [WebMethod]
        public List<Usuario> Mostrar() { return procesos.index(); }
    }
}
