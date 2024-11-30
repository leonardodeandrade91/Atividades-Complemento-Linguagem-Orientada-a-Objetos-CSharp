using System;

namespace POOCozinha {
    class Program {
        static void Main(string[] args) {
            Microondas micro = new Microondas();

            micro.ligar(3, 30);
            micro.ligar("Pipoca");
            micro.ligar(true);

            Console.Read();
        }
    }
}
