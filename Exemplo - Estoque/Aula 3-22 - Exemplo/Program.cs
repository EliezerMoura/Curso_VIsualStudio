using System;
using System.Globalization;

namespace Aula_3_22___Exemplo {
    class Program {
        static void Main(string[] args) {

            Produto P;
            
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            int quantidadeEmEstoque = int.Parse(Console.ReadLine());

            P = new Produto(nome, preco, quantidadeEmEstoque);

            Console.WriteLine();
            Console.WriteLine(P);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
            P.realizarEntrada( int.Parse(Console.ReadLine()));
            
            Console.WriteLine();
            Console.WriteLine(P);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que sairam no estoque: ");
            P.realizarSaida(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine(P);
            Console.ReadLine();
        }
    }
}
