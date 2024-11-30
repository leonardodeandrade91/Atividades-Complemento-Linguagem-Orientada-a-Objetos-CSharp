using System;

namespace PraticaPOO3 {
    abstract class Pessoa {
        protected string nome;
        protected int idade;
        protected string sexo;
        protected float experiencia;

        public override string ToString() {
            return "Pessoa:\nNome = " + nome + "\nIdade = " + idade + "\nSexo = " + sexo + "\nExperiencia = " + experiencia;
        }

        public Pessoa(string nome, int idade, string sexo) {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
            this.experiencia = 0;
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

        public float Experiencia {
            get => this.experiencia;
            set => this.experiencia = value;
        }
    }
}
