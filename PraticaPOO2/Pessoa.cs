using System;

namespace PraticaPOO2 {
    class Pessoa {
        private string nome;
        private int idade;
        private string sexo;

        public void fazerAniver() {
            this.idade++;
        }

        public Pessoa(string nome, int idade, string sexo) {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
        }

        public string Nome {
            get => this.nome;
            set => this.nome = value;
        }

        public int Idade {
            get => this.idade;
            set => this.idade = value;
        }

        public string Sexo {
            get => this.sexo;
            set => this.sexo = value;
        }
    }
}
