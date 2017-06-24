using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conector
{
    public class Create
    {

        public string NombreTabla { get; set; } = "";
        public List<string> ListaValores { get; set; } = new List<string>();
        public string Valores { get; set; } = "";
        public string Tipo { get; set; } = "";
        public string Longitud { get; set; } = "";

    }

    public class Creates
    {
        public string CreateTable(string _nombreTabla, List<string> _listaValores)
        {


            return null;
        }

    }
}
