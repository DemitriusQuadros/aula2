using System;

namespace LacosRepeticao
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int n = 1;
            //while (n <= 10)
            //{
            //    Console.WriteLine(String.Format("Valor corrente de n é: {0}", n));
            //    n++;
            //}
            //Console.ReadKey();

            //int n = 1;
            //do
            //{
            //    Console.WriteLine("Valor de n é: " + n);
            //    n++;
            //} while (n >= 10);
            //Console.ReadKey();

         
            int[] arrayDeInteiros = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int inteiro in arrayDeInteiros)
            {
                Console.WriteLine(inteiro);
            }
            Console.Read();

        }
    }
}
