using System;
using System.Globalization;

namespace Aula_3_22___Exemplo {
    class Produto {
        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidadeEmEstoque { get; private set; }

        public Produto(string nome, double preco, int quantidadeEmEstoque) {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        public Produto(string nome, double preco) {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = 0;
        }

        public override string ToString() {
            return "Dados do produto: " 
                + nome 
                + ", R$ " 
                + preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + quantidadeEmEstoque 
                + " unidades, Total: R$ " 
                + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); ;
        }

        public double valorTotalEmEstoque() {
            return (double) quantidadeEmEstoque * preco;
        }

        public void realizarEntrada(int quantidade) {
            quantidadeEmEstoque = quantidadeEmEstoque + quantidade;
        }
        public void realizarSaida(int quantidade) {
            quantidadeEmEstoque = quantidadeEmEstoque - quantidade;
        }

    }
}
