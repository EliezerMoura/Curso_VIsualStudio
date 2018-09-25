using System;
using System.Globalization;
using System.Collections.Generic;

namespace Aula_4___Proposta_1.dominio {
    class Participacao {
        public Artista artista;
        public double Desconto { get; set; }
        public Filme filme;

        public Participacao(Artista artista, double desconto, Filme filme) {
            this.artista = artista;
            Desconto = desconto;
            this.filme = filme;
        }

        public double Custo() {
            return artista.Cache - Desconto;
        }

        public override string ToString() {
            return artista + ", "
                + ", Desconto: " + Desconto.ToString("F2", CultureInfo.InvariantCulture)
                + ", Custo: " + Custo().ToString("F2", CultureInfo.InvariantCulture);
        }
    }    
}
