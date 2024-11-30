using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceCriandoMenus {
    public partial class Janela : Form {
        public Janela() {
            InitializeComponent();
        }

        private void Janela_FormClosed(object sender, FormClosedEventArgs e) {
            if(Application.OpenForms.Count == 0) {
                Application.Exit();
            }
            else {
                foreach(Form formAber in Application.OpenForms) {
                    if(formAber is Form1) {
                        formAber.Show();
                        break;
                    }
                }
            }
        }
    }
}
