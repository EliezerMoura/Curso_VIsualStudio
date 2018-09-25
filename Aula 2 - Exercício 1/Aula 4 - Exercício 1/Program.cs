using System;

namespace Aula_4___Exercício_1 {
    class Program {
        static void Main(string[] args) {

            Veneno v;

            Console.Write("Volume Inicial(ml): ");
            int vi = int.Parse(Console.ReadLine());
            Console.Write("Vazão(ml): ");
            int va = int.Parse(Console.ReadLine());
            Console.Write("Tempo(s): ");
            int tp = int.Parse(Console.ReadLine());

            v = new Veneno(vi, va, tp);

            Console.WriteLine();
            Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}
