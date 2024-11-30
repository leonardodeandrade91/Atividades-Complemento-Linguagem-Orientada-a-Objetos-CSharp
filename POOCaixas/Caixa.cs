using System;

namespace POOCaixas {
    class Caixa : Estoque {
        private double lado;

        public void defineLado(int l) {
            this.lado = l;
        }

        public double volume() {
            return lado * lado * lado;
        }

        public static int caixaLado2() {
            int lat = 2;
            int vol = lat * lat * lat;

            return vol;
        }

        public Caixa() {
            lado = 10;
        }

        public Caixa(double l) {
            lado = l;
        }

        public double Lado {
            get;
            set;
        }
    }
}
