using System;

namespace Aula_2_14___While
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, qtd, soma;
            idade = int.Parse(Console.ReadLine());

            if (idade > 0)
            {

                soma = 0;
                qtd = 0;

                while (idade > 0)
                {
                    soma = soma + idade;
                    qtd = qtd + 1;
                    idade = int.Parse(Console.ReadLine());
                }

                double media = (double) soma / qtd;

                Console.WriteLine(media.ToString("F2"));
                Console.ReadLine();
            }
            else {
                Console.WriteLine("Impossível Calcular");
                Console.ReadLine();
            }
        }
    }
}
