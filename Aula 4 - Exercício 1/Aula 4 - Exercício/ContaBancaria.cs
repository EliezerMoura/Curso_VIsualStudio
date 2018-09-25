using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula_4___Exercício {
    class ContaBancaria {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        double saldo;

        public ContaBancaria(int numero, string nome, double saldoInicial) {
            this.Numero = numero;
            this.Nome = nome;
            saldo = saldoInicial;
        }

        public ContaBancaria(int numero, string nome) {
            this.Numero = numero;
            this.Nome = nome;
            saldo = 0;

            var a = new List<int>();            
        }

        public void Depositar(double valor) {
            saldo = saldo + valor;

        }

        public void Sacar(double valor) {
            saldo = saldo - valor - 5;
        }
        
        public override string ToString() {
            return "Conta " + Numero + ", Titular: " + Nome + ", Saldo: R$ " + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
