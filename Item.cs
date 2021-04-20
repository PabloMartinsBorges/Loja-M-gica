using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Item
    {
        public String Nome;
        public String Descricao;
        public String Categoria;
        public Int32 Valor;

        public Item(string nome, String descricao, String categoria, Int32 valor)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Categoria = categoria;
            this.Valor = valor;
        }

    }
}
