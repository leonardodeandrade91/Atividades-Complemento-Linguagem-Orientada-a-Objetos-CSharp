namespace InterfaceRadioButton {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdErr = new System.Windows.Forms.RadioButton();
            this.rdAvi = new System.Windows.Forms.RadioButton();
            this.rdInf = new System.Windows.Forms.RadioButton();
            this.btnVerif = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdInf);
            this.panel1.Controls.Add(this.rdAvi);
            this.panel1.Controls.Add(this.rdErr);
            this.panel1.Location = new System.Drawing.Point(129, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 77);
            this.panel1.TabIndex = 0;
            // 
            // rdErr
            // 
            this.rdErr.AutoSize = true;
            this.rdErr.Checked = true;
            this.rdErr.Location = new System.Drawing.Point(16, 3);
            this.rdErr.Name = "rdErr";
            this.rdErr.Size = new System.Drawing.Size(44, 17);
            this.rdErr.TabIndex = 0;
            this.rdErr.TabStop = true;
            this.rdErr.Text = "Erro";
            this.rdErr.UseVisualStyleBackColor = true;
            // 
            // rdAvi
            // 
            this.rdAvi.AutoSize = true;
            this.rdAvi.Location = new System.Drawing.Point(16, 26);
            this.rdAvi.Name = "rdAvi";
            this.rdAvi.Size = new System.Drawing.Size(51, 17);
            this.rdAvi.TabIndex = 1;
            this.rdAvi.Text = "Aviso";
            this.rdAvi.UseVisualStyleBackColor = true;
            // 
            // rdInf
            // 
            this.rdInf.AutoSize = true;
            this.rdInf.Location = new System.Drawing.Point(16, 49);
            this.rdInf.Name = "rdInf";
            this.rdInf.Size = new System.Drawing.Size(78, 17);
            this.rdInf.TabIndex = 2;
            this.rdInf.Text = "Informação";
            this.rdInf.UseVisualStyleBackColor = true;
            // 
            // btnVerif
            // 
            this.btnVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerif.Location = new System.Drawing.Point(129, 182);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(119, 36);
            this.btnVerif.TabIndex = 1;
            this.btnVerif.Text = "Verificar";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 275);
            this.Controls.Add(this.btnVerif);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdInf;
        private System.Windows.Forms.RadioButton rdAvi;
        private System.Windows.Forms.RadioButton rdErr;
        private System.Windows.Forms.Button btnVerif;
    }
}

