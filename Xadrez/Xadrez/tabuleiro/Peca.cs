using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.tabuleiro {
    class Peca {
        public int Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(int posicao, Tabuleiro tabuleiro, Cor cor) {
            Posicao = posicao;
            Cor = cor;
            Tab = tabuleiro;
            QtdMovimentos = 0;
        }
    }
}
