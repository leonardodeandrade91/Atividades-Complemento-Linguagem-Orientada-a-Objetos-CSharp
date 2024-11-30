using System;

namespace ComplCSharp {
    internal class Program {
        enum Domino {pito = 1, duque, terno, quadra, quina, sena};
        
        static void Main(string[] args) {
            Domino dados = Domino.pito;

            for(int i = 0; i < 6; i++) {
                Console.WriteLine($"Dado: {dados}");
                dados++;
            }

            Console.Read();
        }
    }
}