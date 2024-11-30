using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceBrowser {
    public partial class Form1 : Form {
        private string home = null;
        
        public Form1() {
            InitializeComponent();
        }

        private void navegar() {
            if(!txtUrl.Text.Equals("")) {
                brPrinc.Navigate(txtUrl.Text.Trim());
            }
            else {
                MessageBox.Show("Digite algo na URL!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUrl.Focus();
            }
        }

        private void btnIr_Click(object sender, EventArgs e) {
            navegar();
        }
        
        private void txtUrl_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                navegar();
            }
        }

        private void btnHome_Click(object sender, EventArgs e) {
            if(home == null) {
                brPrinc.GoHome();
            }
            else {
                brPrinc.Navigate(home);
            }
        }

        private void brPrinc_CanGoBackChanged(object sender, EventArgs e) {
            btnVolt.Enabled = brPrinc.CanGoBack;
        }

        private void brPrinc_CanGoForwardChanged(object sender, EventArgs e) {
            btnProx.Enabled = brPrinc.CanGoForward;
        }

        private void btnVolt_Click(object sender, EventArgs e) {
            brPrinc.GoBack();
        }

        private void btnProx_Click(object sender, EventArgs e) {
            brPrinc.GoForward();
        }

        private void btnPar_Click(object sender, EventArgs e) {
            brPrinc.Stop();
        }

        private void btnAtu_Click(object sender, EventArgs e) {
            brPrinc.Refresh();
        }

        private void btnPesq_Click(object sender, EventArgs e) {
            brPrinc.GoSearch();
        }

        private void btnDef_Click(object sender, EventArgs e) {
            home = txtUrl.Text.Trim();
        }
    }
}
