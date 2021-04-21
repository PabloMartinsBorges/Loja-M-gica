using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Player : Pessoa
    {
        public String Classe;
        public String Descricao;
        public List<Item> Inventario;


        //Método Construtor de Player
        public Player(String nome, Int32 moedas, String classe, String descricao)
            :base(nome, moedas)
        {
            this.Classe = classe;
            this.Descricao = descricao;
            this.Inventario = new List<Item>();

        }

      /*  public static void Mostrar_Classes()
        {

        }*/

        public void AbrirInventario()
        {
            Console.WriteLine("");
            Console.WriteLine("Inventário:");

            foreach (Item item in this.Inventario)
            {
                Console.WriteLine("-{0}: {1}", item.Nome, item.Descricao);               
            }

            Console.WriteLine("Moedas: " + Moedas);
        }


        //Método para comprar itens da loja
        public void Comprar(String itemDesejado, List<Item> estoque)
        {
            //variaveis genericas para checar se o nome do item existe
            bool itemExiste = false;
            bool varGen = true;

            //o laço faz uma iteração e caso o nome exista dentro da lista itemExiste recebe true
            while(varGen != itemExiste)
            {
                foreach(var i in estoque)
                {
                    if(i.Nome == itemDesejado)
                    {
                        itemExiste = true;
                        break;
                    }
                }
                //Para sair do laço caso itemExiste não seja true
                break;
            }

            //Se o nome do item existe, realizará a compra
            if(itemExiste == true)
            {
                foreach (var item in estoque)
                {
                    if (item.Nome == itemDesejado)
                    {
                        //Caso o Player não possua moedas suficientes ele não efetuará a compra
                        if (item.Valor > this.Moedas)
                        {
                            Console.WriteLine("Você não tem moedas suficientes, vá atrás de baús em masmorras!");
                        }

                        //Caso contrario efetua a compra e exibi o nome do item e o valor
                        else
                        {
                            Console.WriteLine("Você comprou {0} por {1}", item.Nome, item.Valor);
                            this.Inventario.Add(item);
                            this.Moedas -= item.Valor;
                        }

                    }
                }

            }

            //Caso o itemExiste seja false, alertará o usuário para redigitar
            else
            {
                Console.WriteLine("Digite o nome corretamente");
            }

        }

    }
}
