using System;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    internal class Rei: Peca
    {

        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
