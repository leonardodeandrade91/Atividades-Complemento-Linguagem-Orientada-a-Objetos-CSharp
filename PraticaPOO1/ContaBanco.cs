using System;

namespace PraticaPOO1 {
    class ContaBanco {
        public int numConta;
        protected string tipo;
        private string dono;
        private float saldo;
        private bool status;

        public void estadoAtual() {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Conta: {this.NumConta}");
            Console.WriteLine($"Tipo: {this.Tipo}");
            Console.WriteLine($"Dono: {this.Dono}");
            Console.WriteLine($"Saldo: {this.Saldo}");
            Console.WriteLine($"Status: {this.Status}");
        }

        public void abrirConta(string t) {
            this.Tipo = t;
            this.Status = true;

            if(t.Equals("CC")) {
                this.Saldo = 50;
            }
            else if(t.Equals("CP")) {
                this.Saldo = 150;
            }

            Console.WriteLine("Conta aberta com sucesso!");
        }

        public void fecharConta() {
            if(this.Saldo > 0) {
                Console.WriteLine("Conta não pode ser fechada porque ainda tem dinheiro!");
            }
            else if(this.Saldo < 0) {
                Console.WriteLine("Conta não pode ser fechada pois tem débito!");
            }
            else {
                this.Status = false;
                Console.WriteLine($"Conta de {this.Dono} fechada com sucesso!");
            }
        }

        public void depositar(float v) {
            if(this.Status == true) {
                this.Saldo = this.Saldo + v;

                Console.WriteLine($"Depósito de R${v} realizado na conta de {this.Dono}!");
            }
            else {
                Console.WriteLine("Conta fechada ou inexistente!");
            }
        }

        public void sacar(float v) {
            if(this.Status == true) {
                if(this.Saldo >= v) {
                    this.Saldo = this.Saldo - v;

                    Console.WriteLine($"Saque de R${v} realizado na conta de {this.Dono}!");
                }
                else {
                    Console.WriteLine("Saldo insuficiente para saque!");
                }
            }
            else {
                Console.WriteLine("Conta fechada! Impossível sacar!");
            }
        }

        public void pagarMensal() {
            int v = 0;

            if(this.Tipo.Equals("CC")) {
                v = 12;
            }
            else if(this.Tipo.Equals("CP")) {
                v = 20;
            }

            if(this.Status == true) {
                this.Saldo = this.Saldo - v;

                Console.WriteLine($"Mensalidade de R${v} debitada da conta de {this.Dono}!");
            }
            else {
                Console.WriteLine("Não podemos cobrar, problemas na conta!");
            }
        }

        public ContaBanco() {
            this.Saldo = 0;
            this.Status = false;
        }

        public int NumConta {
            get => this.numConta;
            set => this.numConta = value;
        }

        public string Tipo {
            get => this.tipo;
            set => this.tipo = value;
        }

        public string Dono {
            get => this.dono;
            set => this.dono = value;
        }

        public float Saldo {
            get => this.saldo;
            set => this.saldo = value;
        }

        public bool Status {
            get => this.status;
            set => this.status = value;
        }
    }
}
