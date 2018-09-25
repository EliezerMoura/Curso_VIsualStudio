using System;

namespace Aula_4___Exercicio_3 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite a quantidade de linhas e colunas: ");
            string[] temp = Console.ReadLine().Split(' ');
            int M = int.Parse(temp[0]);
            int N = int.Parse(temp[1]);

            int[,] a = new int[M, N];

            for (int i = 0; i < M; i++) {
                Console.Write("Digite a linha " + (i + 1) + ": ");
                temp = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    a[i, j] = int.Parse(temp[j]);
                }
            };

            Console.Write("\r\n" + "Digite o número: ");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if (a[i, j] == X) {
                        if (j + 1 < N)
                            Console.WriteLine("Direita: "  + a[i, j + 1]);
                        if (j > 0)
                            Console.WriteLine("Esquerda: " + a[i, j - 1]);
                        if (i > 0)
                            Console.WriteLine("Acima: "    + a[i - 1, j]);
                        if (i + 1 < M)
                            Console.WriteLine("Abaixo: "   + a[i + 1, j]);

                        break;
                    }
                };
            };

            Console.ReadLine();
        }
    }
}
