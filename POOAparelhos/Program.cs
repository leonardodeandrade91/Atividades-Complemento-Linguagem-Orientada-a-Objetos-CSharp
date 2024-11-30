using System;

namespace POOAparelhos {
    class Program {
        static void Main(string[] args) {
            Pilha ray = new Pilha("Rayovac");

            ray.apresentacao();

            Aparelho controle = new Aparelho(ray);

            controle.ligado();

            Console.WriteLine($"A carga da pilha é de {controle.Pl.Carga}%!");

            Console.Read();
        }
    }
}
