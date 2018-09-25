using System;

namespace Aula_3_20___Classes {
    class Triangulo {

        public double a, b, c;

        public double area() {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));  
        }
    }
}
