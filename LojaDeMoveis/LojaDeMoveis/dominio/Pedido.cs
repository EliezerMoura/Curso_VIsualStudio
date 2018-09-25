using System;
using System.Globalization;
using System.Collections.Generic;


namespace LojaDeMoveis.dominio {
    class Pedido {
        public int codigo { get; set; }
        public DateTime data { get; set; }  
        public List<ItensPedido> itens { get; set; }

        List<ItensPedido> listItens = new List<ItensPedido>();

        public Pedido(int codigo, int dia, int mes, int ano) {
            this.codigo = codigo;
            data = new DateTime(ano, mes, dia);
            itens = new List<ItensPedido>();            
        }

        public void AdicionaItem(int codigo, int quantidade, double desconto) {

        }

        public double valorTotal() {
            double total = 0;
            for (int i = 0; i < itens.Count; i++) {
                total += itens[i].subTotal();
            };
            return total;
        }

        public override string ToString() {
            string r = "Pedido " + codigo + ", data " + data.Day + "/" + data.Month + "/" + data.Year
                + "\n" + "Itens:" + "\n";

            for (int i = 0; i < itens.Count; i++) {
                r += itens[i] + "\n";
            }

            return r + "Total do pedido: R$" + valorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
