namespace Xadrez.tabuleiro {
    abstract class Peca {
        public Posicao posicao;
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor) {
            this.posicao = null;
            Cor = cor;
            Tab = tabuleiro;
            QtdMovimentos = 0;
        }
        
        public abstract bool[,] movimentosPossiveis();
    }
}
