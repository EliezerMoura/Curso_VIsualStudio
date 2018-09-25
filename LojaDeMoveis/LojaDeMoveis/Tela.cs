using System;
using LojaDeMoveis.dominio;

namespace LojaDeMoveis {
    class Tela {

        public static int MostraTela() {
            Console.Clear();
            Console.WriteLine("Bem vindo. Escolha uma das opções do programa:"
                    + "\r\n" + "1 – Listar produtos ordenadamente"
                    + "\r\n" + "2 – Cadastrar produto"
                    + "\r\n" + "3 – Cadastrar pedido"
                    + "\r\n" + "4 – Mostrar dados de um pedido"
                    + "\r\n" + "5 – Sair" + "\r\n");
            Console.Write("Opção: ");
            return Func.iLeia();
        }

        public static void MostraProdutos() {
            Console.WriteLine("------------------------------------" 
                + "\r\n" + "LISTA DE PRODUTOS:" + "\r\n" 
                + "------------------------------------");
            
            for (int i = 0; i < Program.listProd.Count; i++) {
                Console.WriteLine(Program.listProd[i]);
            }
            Console.WriteLine("------------------------------------");
        }

        public static void MostraPedidos() {

            Console.WriteLine("Digite o código do pedido: ");
            int codPed = Func.iLeia();
            int pos = Program.listPed.FindIndex(x => x.codigo == codPed);
            if (pos < 0)
                throw new ModelException("Código de produto não encontrado: " + codPed);

            Console.WriteLine(Program.listPed[pos]);
            Console.WriteLine("------------------------------------");
        }

        public static void CadastraProduto() {
            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Código: ");
            int codigo = Func.iLeia();
            Console.Write("Descrição: ");
            string descricao = Func.sLeia();
            Console.Write("Preço: ");
            double preco = Func.dLeia();

            Program.listProd.Add(new Produto(codigo, descricao, preco));
            Program.listProd.Sort();
        }

        public static void CadastraPedido() {
            Console.WriteLine("Digite os dados do pedido:");
            Console.Write("Código: ");
            int codigo = Func.iLeia();
            Console.Write("Dia: ");
            int dia = Func.iLeia();
            Console.Write("Mês: ");
            int mes = Func.iLeia();
            Console.Write("Ano: ");
            int ano = Func.iLeia();
            Console.Write("Quantos itens tem o pedido: ");
            int qtd = Func.iLeia();

            Pedido p = new Pedido(codigo, dia, mes, ano);

            for (int i = 0; i < qtd; i++) {
                Console.WriteLine("Digite os dados do " + (i + 1) + "º item:");
                Console.Write("Produto(código): ");
                int codProd = Func.iLeia();
                int pos = Program.listProd.FindIndex(x => x.Codigo == codProd);
                if (pos < 0)
                    throw new ModelException("Código de produto não encontrado: " + codigo);

                Console.Write("Quantidade: ");
                int qtdProd = Func.iLeia();
                Console.Write("Porcentagem de desconto: ");
                double porc = Func.dLeia();

                ItensPedido ip = new ItensPedido(p, Program.listProd[pos], qtd, porc);

                p.itens.Add(ip);
            }

            Program.listPed.Add(p);
        }
    }
}
