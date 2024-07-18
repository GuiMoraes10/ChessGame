
using xadrez_console.tabuleiro;

namespace xadrez
{

    // Classe utilizada para trocas as posições padrão de uma matriz para as posições padrão do xadrez
    internal class PosicaoXadrez
    {
        public char Coluna {  get; set; }
        public int Linha { get; set; }
        
        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
