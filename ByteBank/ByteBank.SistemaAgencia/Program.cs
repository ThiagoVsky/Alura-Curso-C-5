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
            string padrao = "[(]?[0-9]{2}[)]?[9][0-9]{4}-?[0-9]{4}";
            string textoTeste = "(61)99604-7681";
            Match teste = Regex.Match(textoTeste, padrao);
            Console.WriteLine(teste);

            Console.ReadLine();
        }
    }
}
