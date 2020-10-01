using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using WS_Clases.Clases;

namespace WS_Datos_Proc.Mante
{
    public class Mantenimiento
    {
        //conexion
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-V78E4N6\\SQL;Initial Catalog=Prueba_Tecnica;Integrated Security=True");

        //insert
        public string insertar(Personas personas)
        {

            try
            {
                SqlCommand sql = new SqlCommand();
                cn.Open();
                sql.Connection = cn;
                sql.CommandType.ToString();
                sql.CommandText = "insert into Usuarios values(@IDUsuario, @Nombre, @Apellidos,@Correo', @telefono)";
                sql.Parameters.Add("@IDUsuario", SqlDbType.Decimal);
                sql.Parameters["@IDUsuario"].Value = Convert.ToInt32( personas.ID_Usuarios);
                sql.Parameters.Add("@Nombre", SqlDbType.NVarChar);
                sql.Parameters["@Nombre"].Value = personas.Nombre;
                sql.Parameters.Add("@Apellidos", SqlDbType.NVarChar);
                sql.Parameters["@Apellidos"].Value = personas.Apellidos;
                sql.Parameters.Add("@Correo", SqlDbType.NVarChar);
                sql.Parameters["@Correo"].Value = personas.Correo;
                sql.Parameters.Add("@telefono", SqlDbType.NVarChar);
                sql.Parameters["@telefono"].Value = personas.telefono;
                sql.ExecuteNonQuery();
                cn.Close();
                return "Se guardo correctamente";
            }
            catch (Exception)
            {
                return "No se inserto";
                throw;
            }
        }

        //mmodificar
        public string Modificar(Personas personas)
        {

            try
            {
                SqlCommand sql = new SqlCommand();
                cn.Open();
                sql.Connection = cn;
                sql.CommandType.ToString();
                sql.CommandText = "Update Usuarios set ID_Usuario=@IDUsuario, Nombre=@Nombre, Apellidos=@Apellidos,Correo=@Correo', telefono=@telefono where id=@ID";
                sql.Parameters.Add("@ID", SqlDbType.Decimal);
                sql.Parameters["@ID"].Value = Convert.ToInt32(personas.ID_Usuarios);
                sql.Parameters.Add("@IDUsuario", SqlDbType.Decimal);
                sql.Parameters["@IDUsuario"].Value = Convert.ToInt32(personas.ID_Usuarios);
                sql.Parameters.Add("@Nombre", SqlDbType.NVarChar);
                sql.Parameters["@Nombre"].Value = personas.Nombre;
                sql.Parameters.Add("@Apellidos", SqlDbType.NVarChar);
                sql.Parameters["@Apellidos"].Value = personas.Apellidos;
                sql.Parameters.Add("@Correo", SqlDbType.NVarChar);
                sql.Parameters["@Correo"].Value = personas.Correo;
                sql.Parameters.Add("@telefono", SqlDbType.NVarChar);
                sql.Parameters["@telefono"].Value = personas.telefono;
                sql.ExecuteNonQuery();
                cn.Close();
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
                    SqlCommand sql = new SqlCommand();
                    sql.Connection = cn;
                    sql.CommandType.ToString();
                    sql.CommandText = "delete from Usuarios where id =@id";
                    sql.Parameters.Add("@id", SqlDbType.Decimal);
                    sql.Parameters["@id"].Value = id;
                    SqlDataAdapter da = new SqlDataAdapter(sql);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                return "Se elimino correctamente";
            }
            catch (Exception)
            {
                return "No se pudo eliminar";
                throw;
            }
        }
        //mostrar
        public List<Personas> mostrar()
        {
            try
            {
                SqlCommand sql = new SqlCommand();
                sql.Connection = cn;
                sql.CommandType.ToString();
                sql.CommandText = "Select * from Usuarios";

                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();
                da.Fill(ds);

             List<Personas> usua = new List<Personas>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    usua.Add(new Personas() { ID = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString()),
                                              ID_Usuarios=Convert.ToInt32(ds.Tables[0].Rows[i][1].ToString()),
                                              Nombre=ds.Tables[0].Rows[i][2].ToString(),
                                              Apellidos=ds.Tables[0].Rows[i][3].ToString(),
                                              Correo=ds.Tables[0].Rows[i][4].ToString(),
                                              telefono=ds.Tables[0].Rows[i][5].ToString()});
                }

                return usua;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        
        
        
        }
        //buscar
        public List<Personas> Buscar(int id)
        {
            try
            {

                SqlCommand sql = new SqlCommand();
                sql.Connection = cn;
                sql.CommandType.ToString();
                sql.CommandText = "Select * from Usuarios where id=@id";
                sql.Parameters.Add("@id", SqlDbType.Decimal);
                sql.Parameters["@id"].Value = id;
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();
                da.Fill(ds);

                List<Personas> usua = new List<Personas>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    usua.Add(new Personas()
                    {
                        ID = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString()),
                        ID_Usuarios = Convert.ToInt32(ds.Tables[0].Rows[i][1].ToString()),
                        Nombre = ds.Tables[0].Rows[i][2].ToString(),
                        Apellidos = ds.Tables[0].Rows[i][3].ToString(),
                        Correo = ds.Tables[0].Rows[i][4].ToString(),
                        telefono = ds.Tables[0].Rows[i][5].ToString()
                    });
                }

                return usua;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }



        }
    }
}