using System;
using System.Globalization;

namespace primeiro_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            Console.WriteLine("Digite as 3 notas:");
            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            delta = b * b - 4.0 * a *c;

            if (delta <= 0.0) {
                Console.WriteLine("Impossível Calcular");
            } else
            {
                x1 = (-b + Math.Sqrt(delta)) / 2.0 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2.0 * a;

                Console.WriteLine(" ");
                Console.WriteLine("X1 = " + x1.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x2.ToString("F4", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
