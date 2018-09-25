using System;
using System.Collections.Generic;

namespace Aula_4___Exercício_5 {
    class Program {
        static void Main(string[] args) {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            
            Console.Write("O Curso A possui quantos alunos? ");
            int iaux = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < iaux; i++) {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("\r\n" + "O Curso B possui quantos alunos? ");
            iaux = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < iaux; i++) {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("\r\n" + "O Curso C possui quantos alunos? ");
            iaux = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < iaux; i++) {
                C.Add(int.Parse(Console.ReadLine()));
            }

            A.UnionWith(B);
            A.UnionWith(C);

            Console.WriteLine("\r\n" + "Total de alunos: " + A.Count);

            Console.ReadLine();
        }
    }
}
