using System;

namespace POOAparelhos {
    class Pilha {
        private string marca;
        private int carga;

        public void apresentacao() {
            Console.WriteLine($"A marca da pilha é {this.marca}.");
            Console.WriteLine($"A carga da pilha é {this.carga}%.");
        }

        public Pilha(string marca) {
            this.marca = marca;
            this.carga = 100;
        }

        public string Marca {
            get => this.marca;
            set => this.marca = value;
        }

        public int Carga {
            get => this.carga;
            set => this.carga = value;
        }
    }
}
