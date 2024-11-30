using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademia {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            FormLogin fLogin = new FormLogin(this);

            fLogin.ShowDialog();
        }

        private void itEntr_Click(object sender, EventArgs e) {
            FormLogin form = new FormLogin(this);

            form.ShowDialog();
        }

        private void itSair_Click(object sender, EventArgs e) {
            this.lblAcs.Text = "0";
            this.lblUser.Text = "---";
            this.imgLed.Image = Properties.Resources.led_red;

            Global.nivel = 0;
            Global.logado = false;
        }

        private void itBanc_Click(object sender, EventArgs e) {
            if(Global.logado) {
                if(Global.nivel >= 3) {

                }
                else {
                    MessageBox.Show("Acesso Não-Permitido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("É Necessário ter um Usuário Logado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void itNovUser_Click(object sender, EventArgs e) {
            if(Global.logado) {
                if(Global.nivel >= 2) {
                    NovoUsuario novoUser = new NovoUsuario();

                    novoUser.ShowDialog();
                }
                else {
                    MessageBox.Show("Acesso Não-Permitido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("É necessário ter um Usuário Logado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void itGestUser_Click(object sender, EventArgs e) {
            if(Global.logado) {
                if(Global.nivel >= 2) {
                    GestaoUsuarios gestUser = new GestaoUsuarios();

                    gestUser.ShowDialog();
                }
                else {
                    MessageBox.Show("Acesso Não-Permitido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("É necessário ter um Usuário Logado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void itNovAul_Click(object sender, EventArgs e) {
            if(Global.logado) {

            }
            else {
                MessageBox.Show("É necessário ter um Usuário Logado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
