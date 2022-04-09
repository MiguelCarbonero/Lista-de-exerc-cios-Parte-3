using System;

namespace Atividade33
{
    class Program
    {
        static void Main(string[] args)
        {
            int luno = 0;
            int matricula = 0;
            double media = 0;


            Console.Write("Digite a quantidade de alunos ");
            luno = Convert.ToInt32(Console.ReadLine());


            for (int x = 0; x < luno; x++)
            {
                Console.Write("\nInsir o numero da matrícula do aluno: ");
                matricula = Convert.ToInt32(Console.ReadLine());

                Console.Write("insira a nota ");
                double nota = Convert.ToInt16(Console.ReadLine());

                media += nota;
            }
            media = media/ luno;

            Console.WriteLine("\nA média da turma foi de " + media);
        }
    }
}
