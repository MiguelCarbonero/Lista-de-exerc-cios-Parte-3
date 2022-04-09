using System;

namespace Atividade47
{
    class Program
    {
        static void Main(string[] args)
        {
            int o;
            int numero1;
            int numero2;
            string cont;
            bool encerrar = false;
            Console.WriteLine("calculadora");
            while (encerrar == false)
            {

                Console.WriteLine("\nEntre com o primeiro nmero ");
                numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEntre com o segundo numero ");
                numero2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nDigite uma das opções para as operações:\n1 – Adição\n2 – Subtração\n3 – Multiplicação\n4 – Divisão");
                o = Convert.ToInt32(Console.ReadLine());


                switch (o)
                {
                    case 1:
                        
                        Console.WriteLine("Resultado de " + numero1 + " + " + numero2 + " = " + (numero1 + numero2));
                        break;
                    case 2:
                        
                        Console.WriteLine("Resultado de " + numero1 + " - " + numero2 + " = " + (numero1 - numero2));
                        break;
                    case 3:
                        
                        Console.WriteLine("Resultado de " + numero1 + " x " + numero2 + " = " + (numero1 * numero2));
                        break;
                    case 4:
                        
                        Console.WriteLine("Resultado de " + numero1 + " / " + numero2 + " = " + (numero1 / numero2));
                        break;
                    default:
                        Console.WriteLine("Opção inválida, digite novamente a opção: ");
                        o = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                Console.WriteLine("\n\nDeseja continuar?(s/n)");
                cont = Console.ReadLine();
                if (cont == "N" || cont == "n")
                {
                    encerrar = true;
                }
            }
            Console.ReadKey();
        }
    }
}
