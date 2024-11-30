using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceRadioButton {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnVerif_Click(object sender, EventArgs e) {
            if(rdErr.Checked) {
                MessageBox.Show("Exemplo de Notificação de Erro!", rdErr.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(rdAvi.Checked) {
                MessageBox.Show("Exemplo de Notificação de Aviso!", rdAvi.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(rdInf.Checked) {
                MessageBox.Show("Exemplo de Notificação de Informação!", rdInf.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
