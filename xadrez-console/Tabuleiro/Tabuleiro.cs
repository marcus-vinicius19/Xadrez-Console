﻿
namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas {  get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int linha,int coluna)
        {
            this.linhas = linha;
            this.colunas = coluna;
            pecas = new Peca[linhas, colunas]; 
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}