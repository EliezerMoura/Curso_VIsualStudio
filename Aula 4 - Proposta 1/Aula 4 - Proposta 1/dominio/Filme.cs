using System;
using System.Globalization;
using System.Collections.Generic;

namespace Aula_4___Proposta_1.dominio {
    class Filme {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public List<Participacao> participacoes = new List<Participacao>();

        public Filme(int codigo, string titulo, int ano) {
            Codigo = codigo;
            Titulo = titulo;
            Ano = ano;
        }

        public double CustoTotal() {
            double custo = 0;
            for (int i = 0; i < participacoes.Count; i++) {
                custo += participacoes[i].Custo();
            }
            return custo;
        }

        public override string ToString() {
            string ret = Codigo + ", Título: " + Titulo + ", Ano: " + Ano + "\n"
                + "Participações: \n";

            for (int i = 0; i < participacoes.Count; i++) {
                ret += participacoes[i] + "\n";
            }

                
            return ret + "\n" + "Custo total do filme: " + CustoTotal();
        }
    }
}
