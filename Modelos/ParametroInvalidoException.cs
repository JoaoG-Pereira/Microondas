using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.Modelos
{
    public  class ParametroInvalidoException : Exception
    {
        public ParametroInvalidoException(string errorMessage) : base(errorMessage) { }
    }
}

