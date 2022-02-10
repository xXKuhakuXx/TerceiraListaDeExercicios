using System;

namespace ListaDeExercicio3Questao1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15]; //[] <<-- Vetor (guarda o numero de valores que for descrito do lado) - (pode ser usado em outros tipos de variaveis[string, double...])

            Console.WriteLine("Digite o valor que será atribuído na posição: 0");
            numeros[0] = System.Convert.ToInt32(Console.ReadLine());


            int maior = numeros[0],menor = numeros[0]; //<<--- Aqui sao criadas as variaveis para resgatar o maior e o menor numero 

            for  (int i = 1; i < 15; i++) //<<---- For-> tambem cria o loopin tipo o do/while, porem o que quebra o looping é o contado do "cronometro" int, 
            {
                Console.WriteLine("Digite o valor que será atribuído na posição: " + i);
                numeros[i] = System.Convert.ToInt32(Console.ReadLine());
               
                if (numeros[i] > maior) //Se o numero for maior que a variavel "maior" ela vai assumir o lugar dela, descartando o numero anterior
                {
                    maior = numeros[i];
                }

                if (numeros[i] < menor) //Se o numero for menor que a variavel "menor" ela vai assumir o lugar dela, descartando o numero anterior
                {
                    menor = numeros[i];  
                } 
            }


            Console.Write("Lista dos números: ");
            for (int i = 0; i < 15; i++)
            {

                Console.Write(" " + numeros[i]);


            }
            Console.WriteLine("");
            Console.WriteLine("Menor número: " + menor);
            Console.WriteLine("Maior número: " + maior);

        }
    }
}


