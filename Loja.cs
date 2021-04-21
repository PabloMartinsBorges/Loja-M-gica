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


        //Método Construtor de Loja
        public Loja()
        {
            //Lista de Itens vai ser instânciada junto com o Objeto
            this.Itens = new List<Item>();
            //Dictionary de Itens vai ser instânciado junto com o Objeto
            this.Catalogo = new Dictionary<string, string>();
        }
        
        //Mostra os nomes do itens e ao lado suas descrições
        public void MostrarCatalogo()
        {
           
            foreach (KeyValuePair<string, string> produto in this.Catalogo)
            {
                String p = String.Format("Produto:\t{0}\n", produto.Key);
                p += String.Format("Descrição:\t{0}\n", produto.Value);
                Console.WriteLine(p);
            }
        }


        //Método para adiconar alguns Objetos de Item à Loja
        public void EstocarLoja()
        {
            Item potion = new Item("poçao de cura", "Um frasco com uma infusão de ervas capaz de curar", "Poções", 20);
            this.Itens.Add(potion);
            this.Catalogo.Add(potion.Nome, potion.Descricao);

            Item antidoto = new Item("antidoto", "Um frasco com uma antidoto para curar envenamento", "Poções", 25);
            this.Itens.Add(antidoto);
            this.Catalogo.Add(antidoto.Nome, antidoto.Descricao);

            Item sword = new Item("espada de ferro", "Uma espada simples feita de ferro", "Poções", 50);
            this.Itens.Add(sword);
            this.Catalogo.Add(sword.Nome, sword.Descricao);
           
            Item cajado = new Item("cajado", "Um Cajado de Madeira resistente e leve", "Armas", 10);
            this.Itens.Add(cajado);
            this.Catalogo.Add(cajado.Nome, cajado.Descricao);

            Item bow = new Item("arco", "Um arco de madeira simples", "Armas", 40);
            this.Itens.Add(bow);
            this.Catalogo.Add(bow.Nome, bow.Descricao);

            Item scroll1 = new Item("pergaminho do fogo", "Pergaminho que conjura uma bola de fogo", "Pergaminhos", 120);
            this.Itens.Add(scroll1);
            this.Catalogo.Add(scroll1.Nome, scroll1.Descricao);

            Item scroll2 = new Item("pergaminho do gelo", "Pergaminho que conjura uma lança de gelo", "Pergaminhos", 120);
            this.Itens.Add(scroll2);
            this.Catalogo.Add(scroll2.Nome, scroll2.Descricao);

            Item armor1 = new Item("armadura de couro", "Uma armadura leve de couro batido", "Armaduras", 70);
            this.Itens.Add(armor1);
            this.Catalogo.Add(armor1.Nome, armor1.Descricao);

            Item armor2 = new Item("armadura de ferro", "Uma armadura pesada de ferro", "Armaduras", 100);
            this.Itens.Add(armor2);
            this.Catalogo.Add(armor2.Nome, armor2.Descricao);

        }
         //Permite que o usuário crie o próprio item
        public void EstocarLoja(String nome, String descricao, String categoria, Int32 valor)
        {
            Item customItem = new Item(nome, descricao, categoria, valor);
            this.Itens.Add(customItem);
            this.Catalogo.Add(customItem.Nome, customItem.Descricao);
        }



        public bool ConfirmarCompra(String itemDesejado, List<Item> estoque, int dinheiro)
        {
            //variaveis genericas para checar se o nome do item existe
            bool itemExiste = false;
            bool varGen = true;

            //o laço faz uma iteração e caso o nome exista dentro da lista itemExiste recebe true
            while (varGen != itemExiste)
            {
                foreach (var i in estoque)
                {
                    if (i.Nome == itemDesejado)
                    {
                        itemExiste = true;
                        break;
                    }
                }
                //Para sair do laço caso itemExiste não seja true
                break;
            }

            bool compra = false;
            //Se o nome do item existe, realizará a compra
            if (itemExiste == true)
            {
                foreach (var item in estoque)
                {
                    if (item.Nome == itemDesejado)
                    {
                        Console.WriteLine("Tem certeza que deseja comprar {0} por {1} moedas ?\n 1 - Sim \n 2 - Não", itemDesejado, item.Valor);
                        Console.WriteLine("Moedas: {0}", dinheiro);
                        compra =  true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Desculpe, poderia repetir");
                compra = false;
            }
            return compra;
        }
    }
}
