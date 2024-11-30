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
    public partial class FormLogin : Form {
        Form1 form;
        DataTable dataTab = new DataTable();
        
        public FormLogin(Form1 f) {
            InitializeComponent();

            form = f;
        }
        private void btnEntr_Click(object sender, EventArgs e) {
            string user = txtLogin.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if(user.Equals("") || senha.Equals("")) {
                MessageBox.Show("Preencha Todos os Campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtLogin.Focus();

                return;
            }

            string sql = "select * from usuario where username = @user and senha = @senha";
            Dictionary<string, string> parametros = new Dictionary<string, string>();

            parametros.Add("@user", user);
            parametros.Add("@senha", CriptSenha.encripta(senha, "SHA-1"));

            dataTab = Banco.consultaBanco(sql, parametros);

            if(dataTab.Rows.Count == 1) {
                form.lblAcs.Text = dataTab.Rows[0].ItemArray[5].ToString();
                form.lblUser.Text = dataTab.Rows[0].Field<string>("username");
                form.imgLed.Image = Properties.Resources.led_green;

                Global.nivel = int.Parse(dataTab.Rows[0].Field<Int64>("nivel").ToString());
                Global.logado = true;

                this.Close();
            }
            else {
                MessageBox.Show("Usuário e/ou Senha Incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCanc_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
