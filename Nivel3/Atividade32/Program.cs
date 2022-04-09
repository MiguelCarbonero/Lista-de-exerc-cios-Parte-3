using System;

namespace Atividade32
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int quantimpar =0;
            int res =0 ;
            int i = 0;
            while (quantimpar >= 0)
            {
                Console.WriteLine($"\nescreva um numero entre 0 a 10(numeros negativo 'quebra') --- linha  {i++}");
                quantimpar = int.Parse(Console.ReadLine());

                if (quantimpar % 2 == 0)
                {
                    
                }

                else
                {
                    res += quantimpar;
                }

            }
            Console.WriteLine($"\nsoma dos numeros impares = {res}");
        }
    }
}
