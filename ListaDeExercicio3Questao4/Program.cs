using System;

namespace ListaDeExercicio3Questao4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;


            Console.WriteLine("Digite o valor inteiro que deseja realizar a tabuada:(0/10)");
            numero = Convert.ToInt32(Console.ReadLine());

            int[] tabuada = new int[numero];




            for (int i = 0; i < 11; i++) 
            {
                Console.WriteLine(i + " x " + numero + " = " + (i * numero));
                Console.ReadLine();
            }


        }
    }
}
