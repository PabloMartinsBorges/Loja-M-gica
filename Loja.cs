using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Loja
    {
        public List<Item> Itens;
        public Dictionary<String, string> Catalogo;

        public Loja()
        {
            this.Itens = new List<Item>();
        }

        public void MostrarCatalogo()
        {
           
            foreach (KeyValuePair<string, string> produto in this.Catalogo)
            {
                String p = String.Format("Produto:\t{0}\n", produto.Key);
                p += String.Format("Descrição:\t{0}\n", produto.Value);
                Console.WriteLine(p);
            }
        }

        public void EstocarLoja()
        {
           
            Item potion = new Item("Poção de Cura", "Um frasco com uma infusão de ervas capaz de curar","Armas", 15);
            this.Itens.Add(potion);
            this.Catalogo.Add("Poção de Cura", "Um frasco com uma infusão de ervas capaz de curar");

            Item sword = new Item("Espada de Ferro", "Uma espada simples feita de ferro","Poções", 50);
            this.Itens.Add(sword);
            this.Catalogo.Add("Espada de Ferro", "Uma espada simples feita de ferro");

            Item scroll = new Item("Pergaminho do Fogo", "Pergaminho que conjura uma bola de fogo","Pergaminhos", 250);
            this.Itens.Add(scroll);
            this.Catalogo.Add("Pergaminho do Fogo", "Pergaminho que conjura uma bola de fogo");
        }
    }
}
