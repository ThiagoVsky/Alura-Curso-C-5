using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class ExtratorDeArgumentos
    {
        private readonly string _argumentos;
        string URL { get; }
        public ExtratorDeArgumentos(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O valor do argumento não pode ser nulo ou vazio.", nameof(url));
            }

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;

            }

        public string GetValor(string nomeParam)
        {
            string args;
            int indiceArgs = URL.IndexOf(nomeParam) + nomeParam.Length + 1;
            //int indiceParam = URL.IndexOf(nomeParam);
            //int tamanhoParam = nomeParam.Length;
            //int indiceArgs = indiceParam + tamanhoParam + 1;
            try
            {
                args = URL.Substring(indiceArgs)
                    .Remove(URL.Substring(indiceArgs)
                    .IndexOf('&'));
                //string argsSubstring = URL.Substring(indiceArgs);
                //int indiceEComercial = argsSubstring.IndexOf('&');
                //args = argsSubstring.Remove(argsSubstring.indiceEComercial);
            }
            catch (ArgumentOutOfRangeException)
            {

                args = URL.Substring(indiceArgs);
            }

            return args;
        }
    }
}
