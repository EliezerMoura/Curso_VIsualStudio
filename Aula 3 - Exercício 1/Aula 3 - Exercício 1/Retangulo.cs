using System;
using System.Globalization;

namespace Aula_3___Exercício_1 {
    class Retangulo {
        public double largura, altura;

        public override string ToString() {
            return "A Área é "
                + area().ToString("F2", CultureInfo.InvariantCulture)
                + ", o Perímetro é "
                + perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + " e a Diagonal é " 
                + diagonal().ToString("F2", CultureInfo.InvariantCulture); 
        }

        public double area() {
            return largura * altura;
        }

        public double perimetro() {
            return largura * 2 + altura * 2;
        }

        public double diagonal() {
            return Math.Sqrt(largura * largura + altura * altura);
        }
    }
}
