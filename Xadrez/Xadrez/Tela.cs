using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.tabuleiro;

namespace Xadrez {
    class Tela {

        public static void ImprimirTabuleiro(Tabuleiro tab) {

            for (int i = 0; i < tab.Linhas; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++) {
                    if (tab.peca(i, j) == null)
                        Console.Write(" -");
                    else {
                        Console.Write(" ");
                        ImprimirPeca(tab.peca(i, j));
                    }
                }
                Console.WriteLine();
            }
            Console.Write("\n   a b c d e f g h");
        }

        public static void ImprimirPeca(Peca peca) {
            if (peca.Cor == Cor.Branco)
                Console.Write(peca);
            else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
