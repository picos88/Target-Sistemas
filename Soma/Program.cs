using System;

namespace TesteVagaDev
{
    public class Program
    {
        static void Main(String[] args)
        {
            int inicio = 13;
            int k = 0;
            int soma = 0;

            for(k=0; k < inicio; k++)
            {
                k = k + 1;
                soma = soma + k;
            }

            Console.WriteLine(soma); //a resposta é 49
        }
    }
}
