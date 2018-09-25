using System;

namespace Aula_3___Exercício_1 {
    class Program {
        static void Main(string[] args) {
            Retangulo a;
            a = new Retangulo();

            Console.Write("Digite a altura do triângulo: ");
            a.altura = double.Parse(Console.ReadLine());
            Console.Write("Digite a largura do triângulo: ");
            a.largura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
