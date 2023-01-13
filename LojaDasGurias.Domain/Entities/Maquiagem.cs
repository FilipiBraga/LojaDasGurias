﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDasGurias.Domain.Entities
{
    public class Maquiagem : Produto
    {
        public string Cor { get; private set; }
        public Maquiagem(string marca, string tipo, string nome, string linha, int quantidade, string cor) : base(marca, tipo, nome, linha, quantidade)
        {
            Cor= cor;
        }
        
    }
}
