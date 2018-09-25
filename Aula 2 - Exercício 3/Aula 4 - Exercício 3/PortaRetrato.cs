using System;

namespace Aula_4___Exercício_3 {
    class PortaRetrato {
        int altura { get; set; }
        int largura { get; set; }

        public PortaRetrato(int altura, int largura) {
            this.altura = altura;
            this.largura = largura;
        }

        public bool cabeRetrato(int altura, int largura) {
            if (((this.altura >= altura) && (this.largura >= largura)) ||
                ((this.largura >= altura) && (this.altura >= largura))) {
                return true;
            } else {
                return false;
            }

        }
    }
}
