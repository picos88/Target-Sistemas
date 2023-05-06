using System;

namespace TesteVagaDev
{
    public class Program
    {
        static void Main(String[] args)
        {
            int inicio = 0;
            int proximo = 1;
            int soma = 0;
            int numero;

            Console.WriteLine(inicio + "," + proximo);
            
            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numero; i++)
            {
                soma = inicio + proximo;
                Console.WriteLine(soma);
                inicio = proximo;
                proximo = soma;

                if (numero == inicio || numero == proximo)
                {
                    Console.WriteLine($"O número faz parte da sequência de Fibonacci!");
                }else if(numero == soma)
                {
                    Console.WriteLine($"O número faz parte da sequência de Fibonacci!");
                }else
                {
                    Console.WriteLine($"O número não faz parte da sequência de Fibonacci!");
                }
            }

                    Console.WriteLine(soma);

        }
    }
}