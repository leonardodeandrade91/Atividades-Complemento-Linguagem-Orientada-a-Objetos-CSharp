using System;

namespace PraticaPOOEst {
    internal class Program {
        static void Main(string[] args) {
            Ventilador.ligar(3);
            Ventilador.ligar(2);
            Ventilador.desligar();

            Console.WriteLine(Ventilador.Ligado);

            Console.Read();
        }
    }
}
