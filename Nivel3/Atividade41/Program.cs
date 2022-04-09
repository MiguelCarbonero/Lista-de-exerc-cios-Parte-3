﻿using System;

namespace Atividade41
{
    class Program
    {
        static void Main(string[] args)
        {
			double idade;
			bool parar = false;
			char letra;
			string categoria;

			do
			{
				do
				{
					Console.Write("Digite a idade");
					idade = double.Parse(Console.ReadLine());
					if (idade < 5)
					{
						Console.WriteLine("\nIdade invalida\n");
					}
				} while (idade < 5);

				if (idade >= 5 && idade < 8)
				{
					categoria = "Infantil A";
				}
				
				else if (idade >= 8 && idade < 12)
				{
					categoria = "Infantil B";
				}

				else if (idade >= 12 && idade < 14)
				{
					categoria = "Juvenil A";
				}

				else if (idade >= 14 && idade < 18)
				{
					categoria = "Juvenil B";
				}

				else
				{
					categoria = "Adultos";
				}


				Console.WriteLine($"A categoria é {categoria}");

				Console.WriteLine("\nDeseja encerrar o programa? (s/n) ");
				letra = entrada.next().charAt(0);
				if (letra == 's' || letra == 'S')
				{
					parar = true;
				}

			} while (parar == false);
		}
    }
}
