using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace InterfaceComandosCMD {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnDir_Click(object sender, EventArgs e) {
            using(Process inicia = new Process()) {
                inicia.StartInfo.FileName = Environment.GetEnvironmentVariable("comspec");
                inicia.StartInfo.Arguments = "/c dir C:\\Users";
                inicia.StartInfo.RedirectStandardOutput = true;
                inicia.StartInfo.UseShellExecute = false;
                inicia.StartInfo.CreateNoWindow = true;

                inicia.Start();
                inicia.WaitForExit();

                string saida = inicia.StandardOutput.ReadToEnd();

                txtDir.Text = saida;
            }
        }

        private void btnNot_Click(object sender, EventArgs e) {
            try {
                Process.Start("notepad.exe");
            }
            catch(Win32Exception ex) {
                MessageBox.Show($"ERRO: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
