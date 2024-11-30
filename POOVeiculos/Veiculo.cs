using System;

namespace POOVeiculos {
    class Veiculo {
        protected string placa;
        private string chassis;
        public int portas;

        public void mostraChassis() {
            Console.WriteLine("O chassis é {0}.", this.chassis);
        }

        public Veiculo() {
            this.placa = "AAA-0000";
            this.chassis = "000000000000000";
            this.portas = 4;
        }
    }
}
