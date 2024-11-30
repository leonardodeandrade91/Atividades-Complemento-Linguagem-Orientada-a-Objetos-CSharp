using System;

namespace POOMamiferos {
    abstract class Mamifero {
        public abstract void lutar();

        public void respirar() {
            Console.WriteLine("Eu Respiro!");
        }

        public void mamar() {
            Console.WriteLine("Eu Mamo!");
        }
    }
}
