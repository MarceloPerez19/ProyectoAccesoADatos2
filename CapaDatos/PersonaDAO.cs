using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class PersonaDAO
    {
        public static DataTable getAll()
        {
            //1. definir y configurar la conexión con el motor de BDD
            //cadena de conexión que utiliza la autenticación que proporciona sql server
            //String cadenaConexion = @"Server=A-SIS-0KP\SQLEXPRESS2016; database=Estudiantes; user id=sa; pwd=isa";
            
            //cadena de conexión utilizando el usuario de windows
            String cadenaConexion = @"Server=A-SIS-0KP\SQLEXPRESS2016; database=Estudiantes; integrated security=true";

            //definir un objeto tipo Conexión para conectarnos con el servidor
            SqlConnection conexion = new SqlConnection(cadenaConexion);
        }
    }
}
