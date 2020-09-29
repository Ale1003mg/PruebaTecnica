using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS_Negocios;
using WS_Negocios.WS_Datos;
//using WS_Negocios.WS_Datos;
using WS_Negocios_clases;
using WS_Negocios_clases.Clases;

namespace WS_negocio_proc.Procedimientos
{
    public class Conexiones_Procedimientos
    {

        DatosSoapClient datos = new DatosSoapClient();

        //Insertar
        public string Insertar(Usuario personas) {
            try
            {
              
                return datos.insertar(personas);
            }
            catch (Exception)
            {

                return "Error en capa de Negocio";
            }
        }
        //Modificar

        public string Modificar(Usuario personas)
        {
            try
            {
                return datos.modificar(personas);
            }
            catch (Exception)
            {

                return "Error en capa de Negocio";
            }
        }
        //Eliminar
        public string Eliminar(int id)
        {
            try
            {

                return datos.Eliminar(id);
            }
            catch (Exception)
            {

                return "Error en capa de Negocio";
            }
        }
        //Buscar
        public List<Usuario> Buscar(int id )
        {
            try
            {
                var aux = datos.Buscar(id);

                List<Usuario> dato = new List<Usuario>();
                foreach (Usuario item in aux)
                {
                    dato.Add(item);
                }
                return dato;
            }
            catch (Exception)
            {

                return null;
            }
        }
        //Mostrar

        public  List<Usuario> index()
        {
            try
            {
                var aux = datos.Mostrar();

                List<Usuario> dato = new List<Usuario>();
                foreach (Usuario item in aux)
                {
                    dato.Add(item);
                }
                return dato;
            }
            catch (Exception)
            {

                return null;
            }
        }
        }
}