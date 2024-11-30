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
    public partial class GestaoUsuarios : Form {
        public GestaoUsuarios() {
            InitializeComponent();

            cbStat.SelectedIndex = 2;
        }

        private void btnNov_Click(object sender, EventArgs e) {
            NovoUsuario novoUser = new NovoUsuario();

            novoUser.ShowDialog();

            dgvUser.DataSource = Banco.obterUsuarioIdNome();
        }

        private void btnSalv_Click(object sender, EventArgs e) {
            if(int.Parse(txtId.Text) <= 0) {
                MessageBox.Show("ID Inexistente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            int linha = dgvUser.SelectedRows[0].Index;
            Usuario user = new Usuario();

            user.id = int.Parse(txtId.Text);
            user.nome = txtNome.Text.Trim();
            user.username = txtNome.Text.Trim();
            user.senha = CriptSenha.encripta(txtSenha.Text.Trim(), "SHA-1");
            user.status = cbStat.Text.ToCharArray()[0].ToString();
            user.nivel = (int)numNiv.Value;

            if(!txtNome.Text.Trim().Equals("") && !txtUser.Text.Trim().Equals("") && !txtSenha.Text.Trim().Equals("")) {
                DataTable dataTab = Banco.obterDadosUsuario(user.id);
                string senhaDb = dataTab.Rows[0].Field<string>("senha").ToString();

                if(senhaDb != user.senha) {
                    DialogResult res = MessageBox.Show("A Senha é Diferente da que Está no Banco!\nDeseja Substituí-la?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(res == DialogResult.No) {
                        return;
                    }
                }

                Banco.atualizarUsuario(user);

                dgvUser[1, linha].Value = txtNome.Text.Trim();
            }
            else {
                MessageBox.Show("Preencha Todos os Campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcl_Click(object sender, EventArgs e) {
            DialogResult res = MessageBox.Show("Deseja Excluir o Cadastro do Banco de Dados?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(res == DialogResult.Yes) {
                Banco.excluirUsuario(int.Parse(txtId.Text));

                dgvUser.Rows.Remove(dgvUser.CurrentRow);

                txtId.Text = 0.ToString();
                txtNome.Clear();
                txtUser.Clear();
                txtSenha.Clear();
                cbStat.Text = "Desativado";
                numNiv.Value = 1;
            }
        }

        private void GestaoUsuarios_Load(object sender, EventArgs e) {
            dgvUser.DataSource = Banco.obterUsuarioIdNome();

            dgvUser.Columns[0].Width = 85;
            dgvUser.Columns[1].Width = 190;
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e) {
            DataGridView dgv = (DataGridView)sender;
            int cont = dgv.SelectedRows.Count;

            if(cont > 0) {
                DataTable dataTab = new DataTable();

                int id = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
                char stat;

                dataTab = Banco.obterDadosUsuario(id);

                txtId.Text = dataTab.Rows[0].Field<Int64>("id").ToString();
                txtNome.Text = dataTab.Rows[0].Field<string>("nome").ToString();
                txtUser.Text = dataTab.Rows[0].Field<string>("username").ToString();
                txtSenha.Clear();

                stat = dataTab.Rows[0].Field<string>("status").ToString().ToCharArray()[0];

                switch(stat) {
                    case 'A':
                        cbStat.Text = "Ativo";
                        break;
                    case 'B':
                        cbStat.Text = "Bloqueado";
                        break;
                    default:
                        cbStat.Text = "Desativado";
                        break;
                }

                numNiv.Value = dataTab.Rows[0].Field<Int64>("nivel");
            }
        }
    }
}
