using System;
using Xadrez.tabuleiro;

namespace Xadrez.xadrez {
    class Cavalo : Peca {
        public Cavalo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {
        }

        public override bool[,] movimentosPossiveis() {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return "C";
        }
    }
}