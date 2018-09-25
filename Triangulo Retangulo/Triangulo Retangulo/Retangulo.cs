using System;

namespace Triangulo_Retangulo {
    class Retangulo : Figura {
        public double a { get; set; }
        public double b { get; set; }

        public Retangulo(double a, double b) {
            this.a = a;
            this.b = b;
        }

        public override double area() {
            return a * b;
        }
    }
}
