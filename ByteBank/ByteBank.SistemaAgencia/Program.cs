using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            ListaContas listaContas = new ListaContas
            (
                new ContaCorrente(1234, 111),
                new ContaCorrente(1234, 222),
                new ContaCorrente(1234, 333),
                new ContaCorrente(1234, 444),
                new ContaCorrente(1234, 555),
                new ContaCorrente(1234, 666),
                new ContaCorrente(1234, 777)
            );
            Console.WriteLine(listaContas.ToString() + ".\n.\n.AAAA");

            listaContas.adicionar
            (
                new ContaCorrente(4321, 8888),
                new ContaCorrente(4321, 9999),
                new ContaCorrente(4321, 10101010),
                new ContaCorrente(4321, 11111111)

            );
            Console.WriteLine(listaContas.ToString() + ".\n.\n.BBBB");


            Console.ReadLine();
        }
    }
}
