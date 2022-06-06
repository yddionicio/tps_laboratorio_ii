using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TraerDatosException: Exception
    {
        public TraerDatosException(string mensaje): base(mensaje)
        {

        }
    }
}
