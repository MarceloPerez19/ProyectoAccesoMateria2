using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    
        public class MateriaDAO
        {
            private static String cadenaConexcion = @"Server=DESKTOP-P2GIT4H; database=Materia; integrated security=true";
        public static int crear(Materia materia)
           {
                
                SqlConnection conexion = new SqlConnection(cadenaConexcion);
                //definir operacion sobre la bdd
                string sql = "insert into DatosMateria(CodMateria, NombreMateria, Nivel, Carrera, FechaCreacion) values(@CodMateria, @NombreMateria, @Nivel, @Carrera, @FechaCreacion)";

                //definir un objeto de la clase command para ejecutar la sentencia sql que hemos creado
                SqlCommand comando = new SqlCommand(sql, conexion);

                //definir los parametros 
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@CodMateria", materia.CodMateria);
                comando.Parameters.AddWithValue("@NombreMateria", materia.NombreMateria);
                comando.Parameters.AddWithValue("@Nivel", materia.Nivel);
                comando.Parameters.AddWithValue("@Carrera", materia.Carrera);
                comando.Parameters.AddWithValue("@FechaCreacion", materia.FechaCreacion);

                //3abrir la conexion y ejecutar el comando 
                conexion.Open();
                int x = comando.ExecuteNonQuery();
                //cerrar conexion
                conexion.Close();

                return x;
            }

        public static int actualizar(Materia materia)
        {
            
            SqlConnection conexion = new SqlConnection(cadenaConexcion);

            //definir operacion sobre la bdd
            string sql = "update DatosMateria set NombreMateria=@NombreMateria, Nivel=@Nivel, Carrera=@Carrera  where CodMateria=@CodMateria ";

            //definir un objeto de la clase command para ejecutar la sentencia sql que hemos creado
            SqlCommand comando = new SqlCommand(sql, conexion);

            //definir los parametros 
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@CodMateria", materia.CodMateria);
            comando.Parameters.AddWithValue("@NombreMateria", materia.NombreMateria);
            comando.Parameters.AddWithValue("@Nivel", materia.Nivel);
            comando.Parameters.AddWithValue("@Carrera", materia.Carrera);

            //3abrir la conexion y ejecutar el comando 
            conexion.Open();
            int x = comando.ExecuteNonQuery();
            //cerrar conexion
            conexion.Close();

            return x;
        }

        public static int eliminar(String CodMateria)
        {
           
            SqlConnection conexion = new SqlConnection(cadenaConexcion);

           
            string sql = "delete from DatosMateria " + "where CodMateria=@CodMateria ";

            
            SqlCommand comando = new SqlCommand(sql, conexion);

          
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@CodMateria", CodMateria);
            


            //3abrir la conexion y ejecutar el comando 
            conexion.Open();
            int x = comando.ExecuteNonQuery();
            //cerrar conexion
            conexion.Close();

            return x;
        }

        public static DataTable getAll()
            {
                //cadena de conezion utiizando el usuario windouws
                

                //definir un objeto tipo conexion para conectarnos al servidor
                SqlConnection conexion = new SqlConnection(cadenaConexcion);

                //definir operacion en el servido; obteneer los registros
                string sql = "select CodMateria, NombreMateria, Nivel, Carrera, FechaCreacion from DatosMateria";

                //definir un adaptador de datos: es un puente qye permite pasar los dato de la bdd al datatable
                SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

                //recuperar datos
                DataTable dt = new DataTable();
                ad.Fill(dt);

                return dt;
            }
        public static Materia getMateria(String CodMateria)
        {

            SqlConnection conexion = new SqlConnection(cadenaConexcion);

            
            string sql = "select CodMateria, NombreMateria, Nivel, Carrera, FechaCreacion " + "from DatosMateria " + "where CodMateria=@CodMateria";

            
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);
            ad.SelectCommand.Parameters.AddWithValue("@CodMateria", CodMateria);

           

            DataTable dt = new DataTable();
            ad.Fill(dt); 

            Materia P = new Materia();
           
            P.CodMateria = " ";
            P.NombreMateria = " ";
            P.Nivel = 0;
            P.Carrera = " ";
            
           
            foreach (DataRow fila in dt.Rows)
            {
                P.CodMateria = fila["CodMateria"].ToString();
                P.NombreMateria = fila["NombreMateria"].ToString();
                P.Nivel = int.Parse(fila["Nivel"].ToString());
                P.Carrera = fila["Carrera"].ToString();
                P.FechaCreacion = Convert.ToDateTime(fila["FechaCreacion"].ToString());
                break;
            }
            return P;

        }
    }
    
}
