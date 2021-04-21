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
            int jogo, menu;
            
            Loja lojinha = new Loja();
            
            lojinha.EstocarLoja();

            Console.WriteLine(" === A Loja Mágica ===");

            do
            {
                //menu principal do jogo
                Console.WriteLine("1 - Criar um Novo Personagem e Iniciar Aventura \n2 - Criar Item \n0 - Terminar Jogo");
                jogo = Convert.ToInt16(Console.ReadLine());

                if (jogo == 1)
                {
                    //menu de criação do personagem
                    Console.WriteLine("=== Criação de Personagem ===\n");
                    Console.Write("Qual o nome do seu personagem: ");
                    String nome = Console.ReadLine();
                    Console.WriteLine("");

                    Console.Write("Qual a classe do seu personagem: ");
                    String classe = Console.ReadLine();
                    Console.WriteLine("");

                    Console.Write("Descreva sua classe:");
                    String descricao = Console.ReadLine();
                    Console.WriteLine("");

                    int moedas = 350;

                    //Intanciândo o personagem do jogador
                    Player jogador = new Player(nome, moedas, classe, descricao);

                    Console.WriteLine("Começa a aventura...");

                    //Hora da história
                    Console.WriteLine("Você, {0}, um jovem que treinou como {1} durante a infância e adolescência para se tornar um {2}", jogador.Nome, jogador.Descricao, jogador.Classe);
                    Console.WriteLine("Um dia quando você se sente confiante na suas habilidades, parte para sua primeira aventura, porém ainda não possui um equipamento apropriado");
                    Console.WriteLine("Você busca pela cidade, mas os preços dos itens estão muito além do seu orçamento, já que você possui apenas {0} e mal paga uma espada de boa qualidade", jogador.Moedas);
                    Console.WriteLine("Na volta, você houve: 'Ei! Psiu! Você aí'. Você olha na direção de um goblin com uma barraquinha bem no final da rua. Ele fala: 'Se você tá procurando desconto, é aqui!");
                    Console.WriteLine("Sem muitas opções, você se aproxima. Ele sorri e fala:'Você veio ao lugar certo! Gizmo tem os melhores produtos de toda cidade, pelo preço que só Gizmo faz!'");
                    Console.WriteLine("");

                    do
                    {
                        //menu principal para compra e acessar o inventário
                        Console.WriteLine("Deseja comprar alguma coisa");
                        Console.WriteLine("1 - Sim(Comprar) \n2 - Abrir Inventário \n0 - Não (Sair)");
                        menu = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("");

                        if (menu == 1)
                        {
                            int opcao;

                            do
                            {
                                //mostra o catalogo e a primeira opção para compra
                                lojinha.MostrarCatalogo();
                                Console.WriteLine("O que você deseja ? (Digite o nome de acordo com o catalogo acima)");
                                String produto = Console.ReadLine();

                                //variável genérica para validar a compra e laço para garantir que o usuário entre com o nome correto e confirme a compra
                                bool compra = false;
                                do
                                {
                                    compra = lojinha.ConfirmarCompra(produto, lojinha.Itens, jogador.Moedas);
                                    if (compra == true)
                                    {
                                        break;
                                    }
                                    produto = Console.ReadLine();

                                } while (compra != true);


                                opcao = Convert.ToInt16(Console.ReadLine());

                                if (opcao != 0 && opcao != 1)
                                {
                                    Console.WriteLine("Digite uma Opção válida!");
                                    Console.WriteLine("");
                                }
                                
                                //adiciona o item no inventário e remove o valor das Moedas
                                if (opcao == 1)
                                {
                                    jogador.Comprar(produto, lojinha.Itens);
                                    
                                    Console.WriteLine("");
                                }

                                Console.WriteLine("");

                                Console.WriteLine("Deseja mais algum produto de Gizmo? \n 1 - Sim \n 0 - Não (Sair)");

                                opcao = Convert.ToInt16(Console.ReadLine());
                                if (opcao != 0 && opcao != 1)
                                {
                                    Console.WriteLine("Digite uma Opção válida!");
                                    Console.WriteLine("");
                                    break;

                                }
                                else if (opcao == 0)
                                {
                                    break;
                                }

                                Console.WriteLine("");



                            } while (opcao != 0);
                        }

                        //abre o inventário
                        else if (menu == 2)
                        {
                            Console.WriteLine("");
                            jogador.AbrirInventario();
                            Console.WriteLine("");
                        }

                        else if (menu != 0)
                        {
                            Console.WriteLine("Digite uma Opção válida!");
                            Console.WriteLine("");

                        }

                    } while (menu != 0);


                }

                //Cria o próprio item e o adiona à loja
                else if (jogo == 2)
                {
                    Console.WriteLine("Digite um nome o item");
                    String n = Console.ReadLine();
                    Console.WriteLine("Escreva uma descrição para o item");
                    String d = Console.ReadLine();
                    Console.WriteLine("digite em que Categoria o item se encaixa");
                    String c = Console.ReadLine();
                    Console.WriteLine("Digite o valor do item em números inteiros positivos");
                    Int32 v = Int32.Parse(Console.ReadLine());

                    lojinha.EstocarLoja(n, d, c, v);

                    Console.WriteLine("Item {0} adiconado", n);
                }

                else if (jogo != 0)
                {
                    Console.WriteLine("Digite uma Opção válida!");
                    Console.WriteLine("");

                }


            } while (jogo != 0);


            Console.WriteLine("Obrigado por Jogar! :)");
            Console.ReadLine();
      

            
        }
      
    }
}
