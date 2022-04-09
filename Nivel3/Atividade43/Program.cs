using System;

namespace Atividade43
{
    class Program
    {
        static void Main(string[] args)
        {
            double graosCasa = 1;
            double tabu = 64;
            int graos = 1;

            for (int x = 1; x < tabu; x++)
            {
                graosCasa = graosCasa * 2;
                graos += (int)graosCasa;
            }

            Console.WriteLine($"\nQuantidade grãos é  + {graos}");
        }
    }
}
