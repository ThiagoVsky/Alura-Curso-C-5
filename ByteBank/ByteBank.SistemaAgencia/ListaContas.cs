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
        int i = 0;
        public ListaContas(params ContaCorrente[] inContas)
        {
            contas = inContas;
        }

        public void adicionar(params ContaCorrente[] inContas)
        {
            i = 0;

            Array.Resize(ref contas, contas.Length + inContas.Length);

            foreach(ContaCorrente conta in inContas)
            {
                contas[contas.Length - inContas.Length + i] = conta;
                Console.WriteLine(".." + conta);
                i++;
            }
            i = 0;

        }
        public ContaCorrente[] GetContas()
        {
            return contas;
        }

        public override string ToString()
        {
            string toString = "";
            i = 0;
            foreach (ContaCorrente conta in contas)
            {
                i++;
                //toString += conta.Numero;
                Console.WriteLine($"Iteração do FOREACH:\n{conta.Numero}");
                Console.WriteLine(i);
            }
            i = 0;
            return toString;
        }

    }
}
