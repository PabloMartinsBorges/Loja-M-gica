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
            



            lojinha.MostrarCatalogo();

            Console.ReadLine();
        }




       
    }
}
