using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS_Negocios;
using WS_Negocios.WS_Datos_User;


namespace WS_negocio_proc.Procedimientos
{
    public class Conexiones_Procedimientos
    {

        DatosSoapClient datos = new DatosSoapClient();
       


        //Insertar
        public string Insertar(Personas personas) {
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

        public string Modificar(Personas personas)
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
        public List<Personas> Buscar(int id )
        {
            try
            {
                var aux = datos.Buscar(id);

                List<Personas> dato = new List<Personas>();
                foreach (Personas item in aux)
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

        public  List<Personas> index()
        {
            try
            {
               
                var aux = datos.Mostrar();

                List<Personas> dato = new List<Personas>();
                foreach (Personas item in aux)
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