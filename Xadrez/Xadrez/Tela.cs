using System;
using Xadrez.tabuleiro;
using Xadrez.xadrez;

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

        public static PosicaoXadrez lerPosicaoXadrez() {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
