﻿using System;
using Xadrez.tabuleiro;
using Xadrez.xadrez;

namespace Xadrez {
    class Program {
        static void Main(string[] args) {
            
            try {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.terminada) {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);                    
                }                
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
