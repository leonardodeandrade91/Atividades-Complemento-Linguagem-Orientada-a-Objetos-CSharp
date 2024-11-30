using System;

namespace POOAparelhos {
    class Aparelho {
        private Pilha pl;

        public void ligado() {
            if(this.pl.Carga > 0) {
                Console.WriteLine($"O aparelho está ligado e a carga da pilha é de {this.pl.Carga}%!");
            }
            else {
                Console.WriteLine($"A pilha do aparelho está sem carga!");
            }
        }

        public Aparelho(Pilha pl) {
            this.pl = pl;
        }

        public Pilha Pl {
            get => this.pl;
            set => this.pl = value;
        }
    }
}
