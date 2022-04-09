using System;

namespace Atividade30
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2000;
            int res;
            Console.WriteLine("escreva o numero para a tabuada");
            int tab = int.Parse(Console.ReadLine());

            for (i = 0; i <= 10; i++)
            {
                res = i * tab;

                Console.WriteLine($"{i} = {res}");
            }
        }
    }
}
