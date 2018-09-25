using System;

namespace Aula_4___Exercício_1 {
    class Veneno {
        public int volumeInicial { get; set; }
        public int vazao { get; set; }
        public int tempo { get; set; }

        public Veneno(int volumeInicial, int vazao, int tempo) {
            this.volumeInicial = volumeInicial;
            this.vazao = vazao;
            this.tempo = tempo;
        }

        public int calcula() {
            int volume = tempo * vazao;
            return volumeInicial - volume;
        }

        public override string ToString() {
            if (calcula() < 0) {
                return "Não é possível.";
            }
            else {
                return "Volume Restante: " + calcula();
            }
        }
    }
}
