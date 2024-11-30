using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceListBox {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if(string.IsNullOrWhiteSpace(txtAddItem.Text)) {
                MessageBox.Show("Digite um Item para Adicionar!", "Digite um Item");
                txtAddItem.Focus();
            }
            else {
                lstAnimais.Items.Add(txtAddItem.Text);
                txtAddItem.Clear();
                txtAddItem.Focus();
            }
        }

        private void btnPreench_Click(object sender, EventArgs e) {
            if(lstAnimais.Items.Count == 0) {
                string[] bichos = {"Jacaré", "Onça", "Elefante", "Gato", "Cão", "Papagaio", "Lontra", "Golfinho", "Foca", "Tatu"};
                lstAnimais.Items.AddRange(bichos);
            }
            else {
                MessageBox.Show("Lista já Preenchida!", "Lista Preenchida");
            }
        }

        private void btnLimp_Click(object sender, EventArgs e) {
            lstAnimais.Items.Clear();
        }

        private void btnRem_Click(object sender, EventArgs e) {
            for(int i = lstAnimais.SelectedIndices.Count - 1; i >= 0; i--) {
                lstAnimais.Items.RemoveAt(lstAnimais.SelectedIndices[i]);
            }
        }

        private void btnLer_Click(object sender, EventArgs e) {
            if(lstAnimais.SelectedIndex < 0) {
                MessageBox.Show("Selecione um Item da Lista!", "Selecione um Item");
            }
            else {
                string item = lstAnimais.SelectedItem.ToString();
                MessageBox.Show("Item Selecionado: " + item, "Item Selecionado");
            }
        }

        private void btnClass_Click(object sender, EventArgs e) {
            lstAnimais.Sorted = true;
        }
    }
}
