using System;

namespace Criptografia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a aplicação de criptografia");
            Console.WriteLine("Informe a senha");
            var senha = Console.ReadLine();

            var senhaCriptografada = Criptografar(senha);

            Console.WriteLine(senhaCriptografada);
            Console.ReadKey();
        }

        public static string Criptografar(string senha)
        {
            var senhaCriptografada = "";
            var random = new Random();
            for (int i = senha.Length; i >= 1; i--)
            {
                senhaCriptografada += senha[i - 1].ToString() + random.Next(9);
            }

            return senhaCriptografada;
        }
    }
}
