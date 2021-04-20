using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Loja lojinha = new Loja();
            lojinha.Catalogo = new Dictionary<string, string>();
            lojinha.EstocarLoja();

            Item potion = new Item("Poção de Cura", "Um frasco com uma infusão de ervas capaz de curar", "Poções", 15);

            String nome = "Pablo";
            Int32 moedas = 100;
            String classe = "Guerreiro";
            String descricao = "Adepto ao combate armado";
            


            Player jogador = new Player(nome, moedas, classe, descricao);
            jogador.Inventario.Add(potion);

            jogador.AbrirInventario();

            lojinha.MostrarCatalogo();

            Console.ReadLine();
        }




       
    }
}
