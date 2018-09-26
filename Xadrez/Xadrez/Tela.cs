﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.tabuleiro;

namespace Xadrez {
    class Tela {

        public static void ImprimirTabuleiro(Tabuleiro tab) {

            for (int i = 0; i < tab.Linhas; i++) {
                for (int j = 0; j < tab.Colunas; j++) {
                    if (tab.peca(i, j) == null)
                        Console.Write(" -");
                    else
                        tab.peca(i, j); 
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}