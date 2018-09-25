using System;

namespace Aula_3___Exercício_3 {
    class Program {
        static void Main(string[] args) {
            Aluno a;
            a = new Aluno();

            Console.Write("Nome: ");
            a.nome = Console.ReadLine();
            Console.WriteLine("Digite as notas: ");
            for (int i = 0; i < 3; i++) {
                a.atualizaNota(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine();
            Console.WriteLine(a);
            Console.ReadLine();            
        }
    }
}
