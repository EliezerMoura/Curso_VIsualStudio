using System;

namespace LojaDeMoveis {
    class Func {
        public static int iLeia() {
            return int.Parse(Console.ReadLine());
        }

        public static double dLeia() {
            return double.Parse(Console.ReadLine());
        }

        public static string sLeia() {
            return Console.ReadLine();
        }

        public static void NovoEspaco() {
            Console.WriteLine();
        }

    }
}
