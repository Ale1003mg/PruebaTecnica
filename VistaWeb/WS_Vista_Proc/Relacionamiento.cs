using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;
//using WS_Vista_Clases.Models;
using WS_Vista_Proc.WS_Negocios;

namespace WS_Vista_Proc
{
    public class Relacionamiento
    {

        NegociosUsuSoapClient client = new NegociosUsuSoapClient();

        

        //insertar
        public string Insert(Personas personas) {

            try
            {

                return client.Insertar(personas);
            }
            catch (Exception)
            {

                return "Error capa vista.";
            }
        }

        // Modificar
        public string Modificar(Personas personas) {

            try
            {

                return client.Modificar(personas);
            }
            catch (Exception)
            {

                return "Error capa vista.";
            }
        }

        //Eliminar
        public string Eliminar(int id) {
            try
            {

                return client.Eliminar(id);
            }
            catch (Exception)
            {

                return "Error capa vista.";
            }
        }
        //Buscar

        public List<Personas> Buscar(int id) {
            try
            {
                var aux = client.Buscar(id);

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
        public List<Personas> Mostrar() {
            try
            {
                var aux = client.Mostrar();

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