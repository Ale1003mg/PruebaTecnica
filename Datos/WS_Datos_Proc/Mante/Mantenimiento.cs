using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace WS_Datos_Proc.Mante
{
    public class Mantenimiento
    {
        //insert
        public string insertar(Usuario usuarios)
        {

            try
            {
                using (Prueba_TecnicaEntities db = new Prueba_TecnicaEntities())
                {
                    db.Usuarios.Add(usuarios);
                    db.SaveChanges();
                }
                return "Se guardo correctamente";
            }
            catch (Exception)
            {
                return "No se inserto";
                throw;
            }
        }

        //mmodificar
        public string Modificar(Usuario usuarios)
        {

            try
            {
                using (Prueba_TecnicaEntities db = new Prueba_TecnicaEntities())
                {
                    db.Usuarios.Find(usuarios);//revisar
                    db.SaveChanges();
                }
                return "Se modifico correctamente";
            }
            catch (Exception)
            {
                return "No se pudo Modificar";
                throw;
            }
        }

        // eliminar
        public string Eliminar(int id)
        {

            try
            {
                using (Prueba_TecnicaEntities db = new Prueba_TecnicaEntities())
                {
                    var datos = (from U in db.Usuarios
                                 where U.id == id
                                 select U).FirstOrDefault();

                    if (datos != null)
                    {
                        db.Usuarios.Remove(datos);
                        db.SaveChanges();
                    }
                }
                return "Se elimino correctamente";
            }
            catch (Exception)
            {
                return "No se pudo eliminar";
                throw;
            }
        }
        //mostrar
        public List<Usuario> mostrar()
        {
            try
            {
                using (Prueba_TecnicaEntities db = new Prueba_TecnicaEntities())
                {
                    var datos = from U in db.Usuarios
                                select U;

                    List<Usuario> usuarios = new List<Usuario>();
                    foreach (Usuario item in datos)
                    {
                        usuarios.Add(item);
                    }
                    return usuarios;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        
        
        
        }
        //buscar
        public List<Usuario> Buscar(int id)
        {
            try
            {
                using (Prueba_TecnicaEntities db = new Prueba_TecnicaEntities())
                {
                    var datos = (from U in db.Usuarios
                                where U.id==id
                                select U).ToList();

                    List<Usuario> usuarios = new List<Usuario>();
                    foreach (Usuario item in datos)
                    {
                        usuarios.Add(item);
                    }
                    return usuarios;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }



        }
    }
}