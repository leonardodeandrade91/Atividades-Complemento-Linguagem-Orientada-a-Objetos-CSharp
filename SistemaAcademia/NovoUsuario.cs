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
    public partial class NovoUsuario : Form {
        public NovoUsuario() {
            InitializeComponent();

            cbStat.SelectedIndex = 2;
        }

        private void btnNov_Click(object sender, EventArgs e) {
            txtNome.Clear();
            txtUser.Clear();
            txtSenha.Clear();
            cbStat.Text = "Desligado";
            numNiv.Value = 1;

            txtNome.Focus();
        }

        private void btnSalv_Click(object sender, EventArgs e) {
            Usuario user = new Usuario();

            user.nome = txtNome.Text.Trim();
            user.username = txtUser.Text.Trim();
            user.senha = CriptSenha.encripta(txtSenha.Text.Trim(), "SHA-1");
            user.status = cbStat.Text.ToCharArray()[0].ToString();
            user.nivel = (int)numNiv.Value;

            if(!txtNome.Text.Trim().Equals("") && !txtUser.Text.Trim().Equals("") && !txtSenha.Text.Trim().Equals("")) {
                Banco.novoUser(user);
            }
            else {
                MessageBox.Show("Preencha Todos os Campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCanc_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
