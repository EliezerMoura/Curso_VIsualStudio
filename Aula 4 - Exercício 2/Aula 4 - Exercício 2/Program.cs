using System;

namespace Aula_4___Exercício_2 {
    class Program {
        static void Main(string[] args) {

            Aluguel[] a = new Aluguel[10];

            Console.Write("Quantos aluguéis serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("\r\n" + "Dados do " + (i+1) + "° aluguel");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                a[quarto] = new Aluguel(nome, email);
            }

            Console.WriteLine("\r\n" + "Quartos ocupados:");

            for (int i = 0; i < 10; i++) {
                if (a[i] != null)
                    Console.WriteLine(i + ": " + a[i]);
            }

            Console.ReadLine();
        }
    }
}
