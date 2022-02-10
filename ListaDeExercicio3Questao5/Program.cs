using System;

namespace ListaDeExercicio3Questao5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fat = 1, numero;


            Console.WriteLine("Digite o valor que deseja calcular o fatorial:");
            numero = System.Convert.ToInt32(Console.ReadLine());


            if (numero < 0)
            {
                Console.WriteLine("Não é possível calcular o fatorial de um número negativo.");
            }
            else if (numero == 0)
            {
                Console.WriteLine("0! = 1");
            }
            else
            {
                Console.Write(numero + "! =");

                for (int i = numero; i >= 1; i--)

                {
                    fat *= i;
                    Console.Write(" " + i + " X ");

                }
                Console.Write(" = " + fat);
            }
        }
    }
}


