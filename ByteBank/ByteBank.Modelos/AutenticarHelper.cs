using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class AutenticarHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaValidar)
        {
            return senhaVerdadeira == senhaValidar;
        }
    }
}
