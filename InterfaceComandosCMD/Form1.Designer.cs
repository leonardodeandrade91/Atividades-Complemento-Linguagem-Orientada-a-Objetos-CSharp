namespace InterfaceComandosCMD {
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
            this.btnDir = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDir
            // 
            this.btnDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDir.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDir.Location = new System.Drawing.Point(102, 31);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(181, 44);
            this.btnDir.TabIndex = 0;
            this.btnDir.Text = "Verificar Diretório C:\\Users";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // btnNot
            // 
            this.btnNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNot.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnNot.Location = new System.Drawing.Point(317, 31);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(181, 44);
            this.btnNot.TabIndex = 1;
            this.btnNot.Text = "Abrir Bloco de Notas";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // txtDir
            // 
            this.txtDir.BackColor = System.Drawing.Color.Black;
            this.txtDir.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDir.ForeColor = System.Drawing.Color.Lime;
            this.txtDir.Location = new System.Drawing.Point(12, 103);
            this.txtDir.Multiline = true;
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(563, 296);
            this.txtDir.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 411);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.btnDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Usando Comandos do CMD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.TextBox txtDir;
    }
}

