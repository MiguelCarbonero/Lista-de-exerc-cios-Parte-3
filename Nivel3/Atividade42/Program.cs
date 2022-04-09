using System;

namespace Atividade42
{
    class Program
    {
        static void Main(string[] args)
        {
			int num;
			int mai;
			int men;

			Console.Write("Digite um numero ");
			num = int.Parse(Console.ReadLine());
			men = num;
			mai = num;

			do
			{
				Console.Write("Digite outro numero ");
				num = int.Parse(Console.ReadLine());

				if (num > mai)
				{
					mai = num;
				}
				if (num < men && num != 0)
				{
					men = num;
				}

			} while (num != 0);

			Console.WriteLine($"\nO menor número é {men} e o maior número é {mai}");
		}
    }
}
