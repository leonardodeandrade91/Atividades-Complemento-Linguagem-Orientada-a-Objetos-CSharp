﻿namespace InterfaceLendoEEscrevendo {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntr = new System.Windows.Forms.TextBox();
            this.txtSaid = new System.Windows.Forms.TextBox();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnEscr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite algo:";
            // 
            // txtEntr
            // 
            this.txtEntr.Location = new System.Drawing.Point(109, 23);
            this.txtEntr.Name = "txtEntr";
            this.txtEntr.Size = new System.Drawing.Size(443, 20);
            this.txtEntr.TabIndex = 1;
            // 
            // txtSaid
            // 
            this.txtSaid.Location = new System.Drawing.Point(12, 66);
            this.txtSaid.Multiline = true;
            this.txtSaid.Name = "txtSaid";
            this.txtSaid.Size = new System.Drawing.Size(540, 292);
            this.txtSaid.TabIndex = 2;
            // 
            // btnLer
            // 
            this.btnLer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLer.Location = new System.Drawing.Point(310, 381);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(213, 54);
            this.btnLer.TabIndex = 3;
            this.btnLer.Text = "Ler Arquivo";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnEscr
            // 
            this.btnEscr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscr.Location = new System.Drawing.Point(46, 381);
            this.btnEscr.Name = "btnEscr";
            this.btnEscr.Size = new System.Drawing.Size(213, 54);
            this.btnEscr.TabIndex = 4;
            this.btnEscr.Text = "Escrever Arquivo";
            this.btnEscr.UseVisualStyleBackColor = true;
            this.btnEscr.Click += new System.EventHandler(this.btnEscr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 447);
            this.Controls.Add(this.btnEscr);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.txtSaid);
            this.Controls.Add(this.txtEntr);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lendo e Escrevendo Arquivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntr;
        private System.Windows.Forms.TextBox txtSaid;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnEscr;
    }
}

