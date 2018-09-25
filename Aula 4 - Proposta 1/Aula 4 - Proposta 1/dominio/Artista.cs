using System;
using System.Globalization;
using System.Collections.Generic;

namespace Aula_4___Proposta_1.dominio {
    class Artista : IComparable {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Cache { get; set; }

        public Artista(int codigo, string nome, double cache) {
            Codigo = codigo;
            Cache = cache;
            Nome = nome;            
        }

        public override string ToString() {
            return Codigo + ", " + Nome + ", Cachê: " + Cache.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) {
            Artista outro = (Artista)obj;
            return Nome.CompareTo(outro.Nome);
        }
    }
}
