using System;
using tabuleiro;

namespace Chess {
    class PartidaDeXadrez {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();            
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Preta), new ChessPosition('c',1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new ChessPosition('c', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new ChessPosition('d', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new ChessPosition('e', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new ChessPosition('e', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new ChessPosition('d', 1).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Branca), new ChessPosition('c', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new ChessPosition('c', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new ChessPosition('d', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new ChessPosition('e', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new ChessPosition('e', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new ChessPosition('d', 8).toPosicao());
        }

    }
}
