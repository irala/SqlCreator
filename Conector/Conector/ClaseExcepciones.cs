using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conector
{
   public class ClaseExcepciones : Exception
    {

        public  ClaseExcepciones(string message, Exception innerException)
            : base (message, innerException)
        { }
    }
}
