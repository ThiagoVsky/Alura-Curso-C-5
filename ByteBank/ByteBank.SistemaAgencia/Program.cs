using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "endereco?moedaOrigem=REAL&moedaDestino=DOLAR";
            ExtratorDeArgumentos extratorDeArgumentos = new ExtratorDeArgumentos(url);

            string moedaOrigem = extratorDeArgumentos.GetValor(nameof(moedaOrigem));
            string moedaDestino = extratorDeArgumentos.GetValor(nameof(moedaDestino));

            Console.WriteLine("A moeda de origem é " + moedaOrigem);
            Console.WriteLine("A moeda de destino é " + moedaDestino);

            Console.WriteLine(url);

            Console.ReadLine();
        }
    }
}
