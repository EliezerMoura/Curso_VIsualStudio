using System;
using System.Collections.Generic;
using LojaDeMoveis.dominio;

namespace LojaDeMoveis {
    class Program {
        public static List<Produto> listProd = new List<Produto>();
        public static List<Pedido>  listPed  = new List<Pedido>();

        static void Main(string[] args) {
            int opcao = 0;            

            listProd.Add(new Produto(1001, "Cadeira Simples", 500));
            listProd.Add(new Produto(1002, "Cadeira acolchoada", 900));
            listProd.Add(new Produto(1003, "Sofá de três lugares", 2000));
            listProd.Add(new Produto(1004, "Mesa retangular", 1500));
            listProd.Add(new Produto(1005, "Mesa retangular", 2000));
            listProd.Sort();

            while (opcao < 5) {
                try {
                    opcao = Tela.MostraTela();
                }
                catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }

                if (opcao == 1) {
                    Tela.MostraProdutos();
                }
                else if (opcao == 2) {
                    try {
                        Tela.CadastraProduto();
                    }
                    catch (ModelException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);                        
                    }
                }
                else if (opcao == 3) {
                    try {
                        Tela.CadastraPedido();
                    }
                    catch (ModelException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 4) {
                    try {
                        Tela.MostraPedidos();
                    }
                    catch (ModelException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 5) {
                    Console.WriteLine("Fim do programa. Obrigado por usá-lo");
                }
                else {
                    Console.WriteLine("Opção inválida");
                }

                Func.sLeia();
            }
            
        }
    }
}
