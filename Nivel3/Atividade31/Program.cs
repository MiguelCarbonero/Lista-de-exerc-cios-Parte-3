using System;

namespace Atividade31
{
    class Program
    {
        static void Main(string[] args)
        {
			int Numero = 0;
			int QuantPar = 0;
			int QuantImpar = 0;

			while (Numero >= 0)
			{

				Console.WriteLine("Digite um número (numeros negativos finalizam): ");
				Numero = int.Parse(Console.ReadLine());
				if (Numero >= 0)
				{
					if (Numero % 2 == 0)
					{
						QuantPar++;
					}
					else
					{
						QuantImpar++;
					}
				}
			}

			Console.WriteLine("\n\nQuantidade de Números Pares: " + QuantPar + "\nQuantidade de Números Impares: " + QuantImpar);
		}
    }
}
