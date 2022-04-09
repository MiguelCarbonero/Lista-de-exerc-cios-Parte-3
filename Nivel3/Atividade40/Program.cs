using System;

namespace Atividade40
{
    class Program
    {
        static void Main(string[] args)
        {
			double numero;
			bool parar = false;
			char letra;

			do
			{
				do
				{
					Console.Write("Digite o indice de poluição: ");
					numero = double.Parse(Console.ReadLine());

					if (numero < 0)
					{
						Console.Write("Numero invalido digite um numero positivo.");
					}
				} while (numero < 0);

				Console.WriteLine();

				if (numero >= 0 && numero <= 0.25)
				{
					Console.WriteLine("indice de poluição aceitavel.");
				}


				if (numero >= 0.3)
				{
					Console.WriteLine("Suspender atividades das industrias do 1° Grupo!");
				}

				if (numero >= 0.4)
				{
					Console.WriteLine("Suspender atividades das industrias do 2° Grupo!");
				}

				if (numero >= 0.5)
				{
					Console.WriteLine("Suspender atividades das industrias do 3° grupo!");
				}

				Console.WriteLine("\nDeseja encerrar o programa? (s/N) ");
				letra = Convert.ToString(Console.ReadLine());
				if (letra == 's' || letra == 'S')
				{
					parar = true;
				}

			} while (parar == false);

		}
    }
}
