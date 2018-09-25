using System;
using System.Globalization;

namespace Aula_3___Exercício_2 {
    class Funcionario {
        public string nome;
        public double salarioBruto, deconto;

        public double salarioLiquido() {
            return salarioBruto - deconto;
        }

        public void aumentarSalario(double porcentagem) {
            salarioBruto = salarioBruto + salarioBruto * porcentagem/100;
        }

        public override string ToString() {
            return "Dados do Funcionário: " + nome + ", R$ " + salarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
