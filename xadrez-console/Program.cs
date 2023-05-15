using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            partidaDeXadrez partida = new partidaDeXadrez();

            Tela.imprimirTabuleiro(partida.tab);

            Console.ReadLine(); 
        }
    }
}