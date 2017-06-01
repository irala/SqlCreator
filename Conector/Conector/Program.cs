using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conector
{
    class Program
    {
        static void Main(string[] args)
        {
            Conectar();
        }
        /// <summary>
        /// Metodo que se conecta a la base de datos y que ejecuta el fichero donde guardamos la consulta.
        /// </summary>
        private static void Conectar()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=DESKTOP-R7LC75I\\SQLSERVER ; database=PRUEBAS ; integrated security = true");
                conexion.Open();
                Console.WriteLine("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
                SqlConector conector = new SqlConector();
                conector.EjecutarSql(conexion, "Copy.sql");


                conexion.Close();
                Console.WriteLine("Se cerró la conexión.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
