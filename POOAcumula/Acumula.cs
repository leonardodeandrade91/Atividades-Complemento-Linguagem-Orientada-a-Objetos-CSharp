using System;

namespace POOAcumula {
    class Acumula {
        public static int soma;

        public Acumula() {
            soma = 0;
        }

        public void incrementa() {
            soma++;
        }

        public void incrementa(int valor) {
            soma += valor;
        }
    }
}
