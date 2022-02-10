using System;

namespace ListaDeExercicio3Questao3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 0; i < 499; i++) 
            {

                if ((i % 2) == 1)
                {
                    soma = soma + i;
                }

            }
            Console.WriteLine("Soma dos valores ímpares entre 0 e 500 é: " + soma);
        }
    }
}



