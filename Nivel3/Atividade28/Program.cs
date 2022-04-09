using System;

namespace Atividade28
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 201; i++)
            {

                if ((i % 2) != 0)
                {
                    Console.WriteLine("Os números ímpares de entre 100 e 200 são: " + i);
                }
            }
        }
    }
}