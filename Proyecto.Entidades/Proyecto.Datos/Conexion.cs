using System;
using System.Data.SqlClient;

namespace Proyecto.Datos
{
    // Clase que manejará la conexión con la base de datos
    public class Conexion
    {
        //  Cadena de conexión 
     
        private static string cadenaConexion =
            "Server=localhost; Database=BD_PROYECTO; Trusted_Connection=True;";

       
        public static SqlConnection ObtenerConexion()
        {
            try
            {
                // Crea la conexión con la cadena
                SqlConnection conexion = new SqlConnection(cadenaConexion);

              

                return conexion;
            }
            catch (Exception ex)
            {
                // Si algo falla, lanzamos el error como texto
                throw new Exception("Error al intentar crear la conexión: " + ex.Message);
            }
        }

      
        public static bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion = ObtenerConexion())
                {
                   
                    Console.WriteLine("Conexión simulada correctamente.");
                    return true;
                }
            }
            catch
            {
                Console.WriteLine("No se pudo establecer conexión.");
                return false;
            }
        }
    }
}