using System;

namespace Atividade39
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool par = false;
            string opcao;


            do
            {
                Console.Write("Digite um numero");
                num = Convert.ToInt32(Console.ReadLine());



                if (num % 2 == 0)
                {
                    Console.Write("\né par");
                }
                else
                {
                    Console.Write("\né ímpar");
                }
                if (num < 0)
                {
                    Console.Write("\né negativo");
                }
                else
                {
                    Console.Write("\né positivo");
                }


                Console.WriteLine("\n\nDeseja sair? (s/n)? ");
                opcao = Convert.ToString(Console.ReadLine());
                if (opcao == "S" || opcao == "s")
                {
                    par = true;
                }


            } while (par == false);
            Console.ReadKey();
        }
    }
}
