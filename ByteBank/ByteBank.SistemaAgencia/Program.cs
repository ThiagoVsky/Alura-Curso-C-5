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
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(0001, 74184688),
                new ContaCorrente(0001, 789343),
                new ContaCorrente(0001, 6541351)
            };
            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"Conta {i}:\n{contas[i]}\n");
            }
            Console.ReadLine();
        }
    }
}
