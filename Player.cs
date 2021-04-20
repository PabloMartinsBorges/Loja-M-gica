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
            foreach (Item item in this.Inventario)
            {
                Console.WriteLine(item.Nome);
            }


        }

    }
}
