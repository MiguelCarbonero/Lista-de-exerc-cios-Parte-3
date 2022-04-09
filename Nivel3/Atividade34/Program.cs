using System;

namespace Atividade34
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int mai;
            int men;


            Console.Write("Entre com um numero (Negativo para fechar) ");
            num = Convert.ToInt32(Console.ReadLine());


            if (num >= 0)
            {
                men = num;
                mai = num;
                while (num >= 0)
                {
                    Console.Write("Entre com outro numero ");
                    num = Convert.ToInt16(Console.ReadLine());
                    if (num > mai)
                    {
                        mai = num;
                    }
                    if (num < men && num >= 0)
                    {
                        men = num;
                    }
                }
                Console.WriteLine("\nO numero maior foi " + mai + " e o menor foi " + men);
            }
        }
    }
}
