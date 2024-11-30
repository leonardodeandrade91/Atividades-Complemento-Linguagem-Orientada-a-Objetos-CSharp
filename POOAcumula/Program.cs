using System;
using System.Collections.Generic;

namespace POOAcumula {
    class Program {
        static void Main(string[] args) {
            IList<Acumula> obj = new List<Acumula>() {
                new Acumula(),
                new Acumula()
            };

            obj[0].incrementa();
            Console.WriteLine("O valor é {0}.", Acumula.soma.ToString());

            obj[1].incrementa(8);
            Console.WriteLine("O valor é {0}.", Acumula.soma.ToString());

            Console.Read();
        }
    }
}
