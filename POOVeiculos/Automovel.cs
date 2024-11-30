using System;

namespace POOVeiculos {
    class Automovel : Veiculo {
        public void dadosAuto() {
            Console.WriteLine("A placa do auto é {0}.", this.placa);
        }
    }
}
