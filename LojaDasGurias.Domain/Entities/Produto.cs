using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDasGurias.Domain.Entities
{
    public class Produto
    {
        public string Marca { get; private set; }
        public string Tipo { get; private set; }
        public string Nome { get; private set; }
        public string Linha { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string marca, string tipo, string nome, string linha, int quantidade)
        {
            Marca = marca;
            Tipo = tipo; ;
            Nome = nome;
            Linha = linha;
            Quantidade = quantidade; 
        }
        
    }
    
}
