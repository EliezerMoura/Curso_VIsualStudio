using System;

namespace Aula_2_14___For {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            int i;
            double A, B;
            for (i = 0; i < N; i++) {
                A = double.Parse(Console.ReadLine());
                B = double.Parse(Console.ReadLine());

                if (B == 0) { Console.WriteLine("Não existe"); }
                else { Console.WriteLine(A / B); }
            }

            Console.ReadLine();
        }
    }
}
