using System;

namespace PraticaPOO1 {
    internal class Program {
        static void Main(string[] args) {
            ContaBanco p1 = new ContaBanco();
            ContaBanco p2 = new ContaBanco();

            p1.abrirConta("CC");
            p1.NumConta = 1111;
            p1.Dono = "Jubileu";

            p2.abrirConta("CP");
            p2.NumConta = 2222;
            p2.Dono = "Creuza";

            p1.depositar(300);
            p2.depositar(500);

            p2.sacar(630);

            p1.pagarMensal();
            p2.pagarMensal();

            p2.fecharConta();

            p1.estadoAtual();
            p2.estadoAtual();

            Console.Read();
        }
    }
}
