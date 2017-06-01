using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conector
{
    public class SqlConector
    {
        /// <summary>
        /// constructor
        /// </summary>
        public SqlConector()
        {

        }
        /// <summary>
        /// Metodo que lee el archivo que le pasamos por parametro y ejecuta la consulta
        /// </summary>
        /// <param name="con"></param>
        /// <param name="archivo"></param>
        public void EjecutarSql(SqlConnection con, string archivo)
        {
            try
            {
                StreamReader sr = new StreamReader(archivo);
                string ret = sr.ReadToEnd();
                sr.Close();
                SqlCommand command = new SqlCommand(ret, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                //No se pudo encontrar el archivo 'c:\users\nuria\documents\visual studio 2015\Projects\Conector\Conector\bin\Debug\prueba.sql'.
                Console.WriteLine(e.Message);
            }

        }



    }
}
