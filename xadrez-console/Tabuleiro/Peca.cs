

namespace xadrez_console.tabuleiro
{
    internal abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca (Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }

        // método abstrato para os movimentos possíveis para cada peca
        public abstract bool[,] movimentosPossiveis();

        // aumenta a quantidade de movimentos em 1 quando a peca se movimentar no tabuleiro
        public void incrementarQteMovimentos()
        {
            QteMovimentos++;
        }

    }
}
