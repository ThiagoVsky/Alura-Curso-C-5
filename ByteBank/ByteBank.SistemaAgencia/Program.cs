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
            DateTime dataFimPagamento = new DateTime(2021, 8, 21);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "falta " + TimeSpanHumanizeExtensions.Humanize(diferenca) + " para o vencimento da fatura";

            Console.WriteLine(mensagem);

            Console.ReadLine();
        }
    }
}
