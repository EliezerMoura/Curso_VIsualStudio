using System;
using Xadrez.tabuleiro;

namespace Xadrez.xadrez {
    class Torre : Peca {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {
        }

        public override bool[,] movimentosPossiveis() {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return "T";
        }
    }
}