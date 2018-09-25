using System;
using System.Globalization;

namespace Aula_3_20___Classes {
    class Program {
        static void Main(string[] args) {

            Triangulo X, Y;
            double areaX, areaY, p;

            X = new Triangulo();
            Y = new Triangulo();

            X.a = double.Parse(Console.ReadLine());
            X.b = double.Parse(Console.ReadLine());
            X.c = double.Parse(Console.ReadLine());
            Y.a = double.Parse(Console.ReadLine());
            Y.b = double.Parse(Console.ReadLine());
            Y.c = double.Parse(Console.ReadLine());

            areaX = X.area();
            areaY = Y.area();

            Console.WriteLine("AREA DO TRIANGULO X: " + areaX.ToString("F4"));
            Console.WriteLine("AREA DO TRIANGULO Y: " + areaY.ToString("F4"));

            if (areaX > areaY) {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: X");
            }
            else if (areaY > areaX) {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: Y");
            }
            else {
                Console.WriteLine("AREAS IGUAIS");
            }

            Console.ReadLine();
        }
    }
}