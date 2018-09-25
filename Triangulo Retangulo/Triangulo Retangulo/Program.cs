using System;
using System.Globalization;
using System.Collections.Generic;


namespace Triangulo_Retangulo {
    class Program {
        static void Main(string[] args) {

            List<Figura> lista = new List<Figura>();
            
            Console.Write("Quantas figuras você vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++) {
                Console.Write("Figura " + (i+1) + " - Triangulo ou Retângulo (t/r)? ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'r') {
                    Figura f = Tela.lerRetangulo();
                    lista.Add(f);
                }
                else {
                    Figura f = Tela.lerTriangulo();
                    lista.Add(f);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Áreas das Figuras:");
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Figura " + (i + 1) + ": " + lista[i].area());
            }


            Console.ReadLine();
        }
    }
}
