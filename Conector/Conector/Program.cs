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
                var respuesta2 = "Y";
                while (respuesta2 == "Y")
                {
                    Console.WriteLine("Que desea hacer?");
                    Console.WriteLine("1.Crear Tabla  2.Copiar Tabla Existente  3.Borrar Tabla  4.Insertar en Tabla  5.Modificar datos Tabla");
                    var respuesta = Console.ReadLine();

                    var fichero = "";
                    switch (respuesta)
                    {
                        case "1":
                            Create c = new Create();
                            Console.WriteLine("Escriba el nombre de la tabla");
                            c.NombreTabla = Console.ReadLine().Trim();
                            Console.WriteLine("Cuantas columnas quieres que tenga");
                            string num = Console.ReadLine();
                            int i = 0;
                            c.ListaValores = new List<string>();
                            while (i < Convert.ToInt32(num))
                            {

                                Console.WriteLine("Escribe el nombre de la columna");
                                c.Valores = Console.ReadLine().Trim();
                                Console.WriteLine("Tipo de valor : a.nvarchar b.int c.char d.datetime e.time f.boolean");
                                var tipo = Console.ReadLine();
                                Console.WriteLine("Longitud del campo");
                                c.Longitud = Console.ReadLine();
                                switch (tipo)
                                {
                                    case "a":
                                        c.Tipo = "nvarchar";
                                        break;
                                    case "b":
                                        c.Tipo = "int";
                                        break;
                                    case "c":
                                        c.Tipo = "char";
                                        break;
                                    case "d":
                                        c.Tipo = "Datetime";
                                        break;
                                    case "e":
                                        c.Tipo = "Time";
                                        break;
                                    case "f":
                                        c.Tipo = "boolean";
                                        break;

                                }
                                var _valorEntero = c.Valores + " " + c.Tipo + "(" + c.Longitud + ")";
                                c.ListaValores.Add(_valorEntero);
                                i++;
                            }

                            var correcto = new Creates().CreateTable(c.NombreTabla, c.ListaValores);

                            // fichero = "Create.sql";
                            break;
                        case "2":
                            fichero = "Copy.sql";
                            break;
                        case "3":
                            fichero = "Drop.sql";
                            break;
                        case "4":
                            fichero = "Insert.sql";
                            break;
                        case "5":
                            fichero = "Update.sql";
                            break;
                    }
                    Console.WriteLine("Estas seguro? Y/N");
                    respuesta = Console.ReadLine();
                    if (respuesta == "Y")
                    {
                        conector.EjecutarSql(conexion, fichero);
                    }
                    else
                    {
                        Console.WriteLine("Desea realizar otra operacion?  Y/N");
                        respuesta2 = Console.ReadLine();

                    }
                }

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
