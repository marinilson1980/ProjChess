using System;
using System.Collections.Generic;
using tabuleiro;

namespace Chess {
    class ChessPosition {
        public char coluna { get; set; }
        public int linha { get; set; }

        public ChessPosition(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public override string ToString()
        {
            return "" + coluna + linha; 
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }
    }
}
