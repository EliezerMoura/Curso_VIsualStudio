using System;
using Xadrez.tabuleiro;
using Xadrez.xadrez;

namespace Xadrez {
    class Program {
        static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8,8);

            for (int i = 0; i < 8; i++)
                tab.colocarPeca(new Peao(tab, Cor.Preto), new Posicao(1, i));
            for (int i = 0; i < 8; i++)
                tab.colocarPeca(new Peao(tab, Cor.Branco), new Posicao(6, i));
            tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 7));
            tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(7, 0));
            tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(7, 7));
            tab.colocarPeca(new Cavalo(tab, Cor.Preto), new Posicao(0, 1));
            tab.colocarPeca(new Cavalo(tab, Cor.Preto), new Posicao(0, 6));
            tab.colocarPeca(new Cavalo(tab, Cor.Branco), new Posicao(7, 1));
            tab.colocarPeca(new Cavalo(tab, Cor.Branco), new Posicao(7, 6));
            tab.colocarPeca(new Bispo(tab, Cor.Preto), new Posicao(0, 2));
            tab.colocarPeca(new Bispo(tab, Cor.Preto), new Posicao(0, 5));
            tab.colocarPeca(new Bispo(tab, Cor.Branco), new Posicao(7, 2));
            tab.colocarPeca(new Bispo(tab, Cor.Branco), new Posicao(7, 5));
            tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(0, 3));
            tab.colocarPeca(new Rei(tab, Cor.Branco), new Posicao(7, 3));
            tab.colocarPeca(new Rainha(tab, Cor.Preto), new Posicao(0, 4));
            tab.colocarPeca(new Rainha(tab, Cor.Branco), new Posicao(7, 4));

            Tela.ImprimirTabuleiro(tab);
        }
    }
}
