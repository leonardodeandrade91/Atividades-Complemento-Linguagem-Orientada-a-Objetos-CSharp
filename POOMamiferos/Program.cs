using System;

namespace POOMamiferos {
    internal class Program {
        static void Main(string[] args) {
            Mamifero homem = new Humano();
            Mamifero bichano = new Gato();

            homem.lutar();

            bichano.lutar();
            
            Console.Read();
        }
    }
}
