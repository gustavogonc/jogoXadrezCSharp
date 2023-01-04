﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using Xadrez_console.tabuleiro;

namespace Xadrez_console
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i =0; i<tab.linhas; i++)
            {
                for(int j = 0; j<tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.WriteLine(tab.peca(i, j) + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
