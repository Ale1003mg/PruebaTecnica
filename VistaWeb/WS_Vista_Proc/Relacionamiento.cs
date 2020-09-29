using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using WS_Vista_Clases.Models;
using WS_Vista_Proc.WS_Negocios;

namespace WS_Vista_Proc
{
    public class Relacionamiento
    {

        NegociosUsuSoapClient client = new NegociosUsuSoapClient();

        

        //insertar
        public string Insert(Usuario personas) {

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
        public string Modificar(Usuario personas) {

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

        public List<Usuario> Buscar(int id) {
            try
            {
                var aux = client.Buscar(id);

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
        public List<Usuario> Mostrar() {
            try
            {
                var aux = client.Mostrar();

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