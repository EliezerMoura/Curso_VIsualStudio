using System;
using System.Globalization;

namespace Aula_4___Exercício_2 {
    class Program {
        static void Main(string[] args) {

            Aluno a;

            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Nota 1:");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2:");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3:");
            double nota3 = double.Parse(Console.ReadLine());

            a = new Aluno(nome, nota1, nota2, nota3);

            Console.WriteLine();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
