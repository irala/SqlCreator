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
          
           
           Console.ReadKey();
             Conectar();
        }
<<<<<<< HEAD

        private static double returnDouble(double par1, double par2)
        {
            double res = par1 / par2;

            return Double.IsPositiveInfinity(res) ? 0.0 : res;
        }

      
=======
>>>>>>> master
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
<<<<<<< HEAD
                conector.EjecutarSql(conexion, "Vista.sql");
=======
                conector.EjecutarSql(conexion, "Copy.sql");
>>>>>>> master


                conexion.Close();
                Console.WriteLine("Se cerró la conexión.");
                Console.ReadKey();
            }
            catch (ClaseExcepciones e)
            {
                throw e;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           

        }
    }
}
