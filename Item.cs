using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Item
    {
        String Nome;
        String Descricao;
        String Categoria;
        Int32 Valor;

        public Item(string nome, String descricao, String Categoria, Int32 valor)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Valor = valor;
        }

    }
}
