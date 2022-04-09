using System;

namespace Atividade35
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;


            for (numero = 1; numero <= 100; numero++)
            {
                if (numero % 10 == 0)
                {
                    Console.WriteLine(numero + " Multiplo de 10");
                }
                else
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
