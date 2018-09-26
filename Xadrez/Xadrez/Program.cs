using System;
using Xadrez.tabuleiro;
using Xadrez.xadrez;

namespace Xadrez {
    class Program {
        static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8,8);

            try {
                PartidaXadrez partida = new PartidaXadrez();

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
