using System;

namespace ManipulacaoTexto
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //FUNCAO DE SUBSTITUICAO DE TEXTO
            //string textoAntigo = "Esse é um texto ANTIGO";
            //string textoNovo = textoAntigo.Replace("ANTIGO", "JOAZINHO");
            //Console.WriteLine(textoNovo);
            //Console.ReadKey();

            //substring selecionando parte do texto
            //string textoAntigo = "0123456";
            //string textoNovo = textoAntigo.Substring(1, 3);
            //Console.WriteLine(textoNovo);
            //Console.ReadKey();

            //string textoAntigo = "ESTOU APRENDENDO C#";
            //string textoNovo = textoAntigo.ToLower().Replace("aprendendo", "ensinando").Substring(0, 10); ;
            //Console.WriteLine(textoNovo);
            //Console.ReadKey();
            Substituir();
        }

        public static void Substituir()
        {
            Console.WriteLine("Informe um nome");
            var textoAntigo = Console.ReadLine();
            Console.WriteLine(textoAntigo.Replace(" ", ";"));
        }

    }
}
