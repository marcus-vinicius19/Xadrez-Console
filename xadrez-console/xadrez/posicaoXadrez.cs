using System;

namespace xadrez
{
    internal class posicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; } 

        public posicaoXadrez(char coluna, int linha) { 
        
            
            this.coluna = coluna;   
            this.linha = linha;
        }

        public override string ToString()
        {
            return " "  + coluna + linha; 
        }
    }
}
