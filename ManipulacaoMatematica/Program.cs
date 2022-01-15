using System;

namespace ManipulacaoMatematica
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CalcularComprimentoBobina(20, 150) + " metros de comprimento");

            Console.WriteLine(CalcularComprimentoBobina(10, 135) + " metros de comprimento");

            Console.WriteLine(CalcularComprimentoBobina(15, 250) + " metros de comprimento");
        }

        public static double CalcularComprimentoBobina(int quantidadeVoltas, double circunferencia)
        {
            var comprimento = (quantidadeVoltas * circunferencia * Math.PI) / 1000;
            return Math.Round(comprimento,3);

        }
    }
}
