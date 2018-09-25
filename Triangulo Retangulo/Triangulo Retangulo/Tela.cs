using System;
using System.Globalization;

namespace Triangulo_Retangulo {
    class Tela {

        public static Retangulo lerRetangulo() {
            Console.Write("Largura: ");
            double Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double Altura = double.Parse(Console.ReadLine());

            return new Retangulo(Largura, Altura);
        }

        public static Triangulo lerTriangulo() {
            Console.Write("Lado a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Lado b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Lado c: ");
            double c = double.Parse(Console.ReadLine());

            return new Triangulo(a, b, c);
        }
    }
}
