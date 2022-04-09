using System;

namespace Atividade36
{
    class Program
    {
        static void Main(string[] args)
        {
            int media = 0;
            int num = 0;
            int soma = 0;
            int mai = num;
            int men = 0;


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o numero {i + 1} ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < men)
                {
                    num = men;
                }


                else if (num > mai)
                {
                    mai = num;
                }

                soma = soma + num;

            }
            media = soma / 10;



            Console.WriteLine("\nO menor nimero é " + men);
            Console.WriteLine("O maior numero é " + mai);
            Console.WriteLine("A média dos numeros é " + media);
        }
    }
}
