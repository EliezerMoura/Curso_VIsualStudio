using System;
using System.Globalization;
using System.Collections.Generic;

namespace Aula_4___Exercicio_4 {
    class Funcionario {
        public int CPF { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int cpf, string nome, double salario) {
            CPF = cpf;
            Nome = nome;
            Salario = salario;
        }

        public void AumentaSalario(double porc) {
            Salario += Salario*(porc/100);
        }

        public override string ToString() {
            return CPF + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
