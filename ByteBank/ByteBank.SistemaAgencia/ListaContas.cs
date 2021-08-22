using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class ListaContas
    {
        ContaCorrente[] contas = null;

        public ListaContas(params ContaCorrente[] contas)
        {
            this.contas = contas;
        }

        public void adicionar(params ContaCorrente[] contas)
        {
            
            Array.Resize(ref this.contas, this.contas.Length + contas.Length);

        }
        public ContaCorrente[] GetContas()
        {
            return contas;
        }

    }
}
