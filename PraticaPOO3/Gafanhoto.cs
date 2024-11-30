using System;

namespace PraticaPOO3 {
    class Gafanhoto : Pessoa {
        private string login;
        private int totAssistido;

        public void assistirMaisUm() {
            this.totAssistido++;
        }

        public override string ToString() {
            return "Gafanhoto:\n" + base.ToString() + "\nLogin = " + login + "\nTotAssistido = " + totAssistido + "\n";
        }

        public Gafanhoto(string nome, int idade, string sexo, string login) : base(nome, idade, sexo) {
            this.login = login;
            this.totAssistido = 0;
        }

        public string Login {
            get => this.login;
            set => this.login = value;
        }

        public int TotAssistido {
            get => this.totAssistido;
            set => this.totAssistido = value;
        }
    }
}
