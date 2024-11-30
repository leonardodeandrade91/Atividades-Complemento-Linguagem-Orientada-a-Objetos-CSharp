using System;

namespace POOMamiferos {
    class Gato : Mamifero {
        public void arranhar() {
            Console.WriteLine("Eu Arranho!");
        }

        public override void lutar() {
            Console.WriteLine("Gatos Lutam Arranhando!");
        }
    }
}
