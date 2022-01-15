using System;

namespace ExercicioCondicionais
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe a sua idade");
            var textoIdade = Console.ReadLine();
            var idade = Convert.ToInt32(textoIdade);
            CalcularIdade(idade);
        }

        public static void CalcularIdade(int idade)
        {
            if (idade >= 13 && idade < 19)
            {
                Console.WriteLine("Adolescente");
            }
            else if (idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Adulto");
            }
            else if (idade > 60)
            {
                Console.WriteLine("Idoso");
            }
            else
            {
                Console.WriteLine("Criança");
            }
        }
    }
}
