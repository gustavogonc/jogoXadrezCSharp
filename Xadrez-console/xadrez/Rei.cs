﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using Xadrez_console.tabuleiro;

namespace xadrez
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab,cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
