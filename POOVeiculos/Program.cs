using System;

namespace POOVeiculos {
    internal class Program {
        static void Main(string[] args) {
            Automovel meuCarro = new Automovel();

            meuCarro.dadosAuto();
            meuCarro.mostraChassis();

            Console.WriteLine(meuCarro.portas.ToString());

            Veiculo carro = new Veiculo();

            carro.mostraChassis();

            Console.Read();
        }
    }
}
