using System.Globalization;

namespace LojaDeMoveis.dominio {
    class ItensPedido {
        public Pedido  pedido  { get; set; }
        public Produto produto { get; set; }
        public int  quantidade { get; set; }
        public double desconto { get; set; }

        public ItensPedido(Pedido pedido, Produto produto, int quantidade, double desconto) {
            this.pedido = pedido;
            this.produto = produto;
            this.quantidade = quantidade;
            this.desconto = desconto;
        }

        public double subTotal() {
            return (produto.Preco * quantidade) * (1 - (desconto / 100));
        }

        public override string ToString() {
            return produto.Descricao
                + ", Preço: " + produto.Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", Qtd: " + quantidade
                + ", Desconto: " + desconto.ToString("F2", CultureInfo.InvariantCulture)
                + "%, Subtotal: " + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }    
}
