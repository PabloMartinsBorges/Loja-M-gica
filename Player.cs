using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Player : Pessoa
    {
        String Classe;
        String Descricao;
        List<Item> Inventario;

        public Player(String nome, Int32 moedas, String classe, String descricao, List<Item> inventario)
            :base(nome, moedas)
        {
            this.Classe = classe;
            this.Descricao = descricao;
            this.Inventario = inventario;
        }

      /*  public static void Mostrar_Classes()
        {

        }*/

        public void Abririnventario()
        {          
            foreach(var item in this.Inventario)
            {
                Console.WriteLine(item);
            }
        }

    }
}
