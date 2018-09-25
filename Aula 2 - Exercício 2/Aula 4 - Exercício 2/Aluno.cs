using System;
using System.Globalization;

namespace Aula_4___Exercício_2 {
    class Aluno {
        string nome  { set; get; }
        double nota1 { set; get; }
        double nota2 { set; get; }
        double nota3 { set; get; }

        public Aluno(string nome, double nota1, double nota2, double nota3) {
            this.nome  = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public double calculaNota() {
            return nota1 + nota2 + nota3;
        }

        public override string ToString() {
            string r = calculaNota().ToString("F2", CultureInfo.InvariantCulture);

            if (calculaNota() < 60)
                r = r + "\r\n" + "DEPENDENCIA";

            return r;                
        }
    }
}
