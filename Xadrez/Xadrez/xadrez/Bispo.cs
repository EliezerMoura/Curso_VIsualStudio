using System;
using Xadrez.tabuleiro;

namespace Xadrez.xadrez {
    class Bispo : Peca {
        public Bispo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {
        }

        public override bool[,] movimentosPossiveis() {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return "B";
        }
    }
}