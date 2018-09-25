using System;
using System.Globalization;

namespace Aula_3___Exercício_3 {
    class Aluno {
        public string nome;
        public int nota;

        public void atualizaNota(int novaNota) {
            nota = nota + novaNota;
        }
        
        public override string ToString() {
            if (nota >= 60) {
                return "NOTA FINAL = " + nota.ToString("F2", CultureInfo.InvariantCulture)
                    + "\r\n" + "APROVADO";
            } else {
                return "NOTA FINAL = " + nota.ToString("F2", CultureInfo.InvariantCulture)
                    + "\r\n" + "REPROVADO \r\n" + "Faltam " + (60 - nota) + "pontos";
            }
            
        }
    }
}
