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
            
            lojinha.EstocarLoja();

            //Criando um Objeto de Item como exemplo
            Item potion = new Item("Poção de Cura", "Um frasco com uma infusão de ervas capaz de curar", "Poções", 15);

            //Exemplo de Atributos para serem inseridos no Objeto de Player
            String nome = "Pablo";
            Int32 moedas = 100;
            String classe = "Guerreiro";
            String descricao = "Adepto ao combate armado";

            //Instaciando o Objeto jogador         
            Player jogador = new Player(nome, moedas, classe, descricao);
           
           //teste para adicionar itens ao Inventario do Player(jogador)
            jogador.Inventario.Add(potion);

            //Testando o Método para mostar os itens no Inventario
            jogador.AbrirInventario();

            //Testando o Método de Mostar os itens armazenados junto com suas descrições
            lojinha.MostrarCatalogo();


            //testando o método Compra
            jogador.Comprar("Pergaminho do Fogo", lojinha.Itens);
            jogador.Comprar("Poção de Cura", lojinha.Itens);
            jogador.Comprar("Poção", lojinha.Itens);

            jogador.AbrirInventario();

            //Manter o Console aberto (Visual Studio)
            Console.ReadLine();
        }




       
    }
}
