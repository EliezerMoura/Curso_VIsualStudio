using System;
using Xadrez.tabuleiro;

namespace Xadrez.xadrez {
    class PartidaXadrez {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor JogadorAtual;
        public bool terminada { get; private set; }

        public PartidaXadrez() {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            JogadorAtual = Cor.Branco;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino) {
            Peca p = tab.retirarPeca(origem);
            p.IncrementarQtdMovimentos();
            Peca PecaCapturada = p;
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas() {
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
        }
    }
}
