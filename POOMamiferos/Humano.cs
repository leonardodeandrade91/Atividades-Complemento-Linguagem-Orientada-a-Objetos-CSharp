using System;

namespace POOMamiferos {
    class Humano : Mamifero {
        public void falar() {
            Console.WriteLine("Eu Falo!");
        }

        public override void lutar() {
            Console.WriteLine("Humanos Lutam com Armas!");
        }
    }
}
