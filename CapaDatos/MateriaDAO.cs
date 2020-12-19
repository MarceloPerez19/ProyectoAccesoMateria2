using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaADatos2
{
    
        public class MateriaDAO
        {


            public static DataTable getAll()
            {
                //cadena de conezion utiizando el usuario windouws
                String cadenaConexcion = @"Server=USER-PC\SQLEXPRESS; database=Materia; integrated security=true";

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
        }
    
}
