 using System;

namespace Atividade27
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            int num = 0;
            int resul =1;

            Console.WriteLine("escreva o numero para o fatorial");
            num = int.Parse(Console.ReadLine());

            for (i = num; i >= 1; i--) {

               // Console.WriteLine($"{num}");

                resul *= num;
     
            }
            Console.WriteLine($"esse é o fatorial de {num} = {resul}");
        }
    }
}
