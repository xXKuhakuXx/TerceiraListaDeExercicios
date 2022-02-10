using System;

namespace ListaDeExercicio3Questao2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números ímpares entre 100 e 200:");

            for (int i = 100; i < 201; i++)
            {

                if ((i % 2) != 0)
                {
                    Console.Write(" " + i + " ,");
                }

            }


        }
    }
}

