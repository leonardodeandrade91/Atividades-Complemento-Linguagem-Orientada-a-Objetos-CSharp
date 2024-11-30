namespace InterfaceClasseColor {
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
            this.btnCorFundo = new System.Windows.Forms.Button();
            this.btnCorTexto = new System.Windows.Forms.Button();
            this.txtCores = new System.Windows.Forms.TextBox();
            this.cdgCaixaCores = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnCorFundo
            // 
            this.btnCorFundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorFundo.Location = new System.Drawing.Point(85, 55);
            this.btnCorFundo.Name = "btnCorFundo";
            this.btnCorFundo.Size = new System.Drawing.Size(185, 39);
            this.btnCorFundo.TabIndex = 0;
            this.btnCorFundo.Text = "Cor de Fundo";
            this.btnCorFundo.UseVisualStyleBackColor = true;
            this.btnCorFundo.Click += new System.EventHandler(this.btnCorFundo_Click);
            // 
            // btnCorTexto
            // 
            this.btnCorTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorTexto.Location = new System.Drawing.Point(276, 55);
            this.btnCorTexto.Name = "btnCorTexto";
            this.btnCorTexto.Size = new System.Drawing.Size(185, 39);
            this.btnCorTexto.TabIndex = 1;
            this.btnCorTexto.Text = "Cor do Texto";
            this.btnCorTexto.UseVisualStyleBackColor = true;
            this.btnCorTexto.Click += new System.EventHandler(this.btnCorTexto_Click);
            // 
            // txtCores
            // 
            this.txtCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCores.Location = new System.Drawing.Point(12, 116);
            this.txtCores.Multiline = true;
            this.txtCores.Name = "txtCores";
            this.txtCores.Size = new System.Drawing.Size(532, 266);
            this.txtCores.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 394);
            this.Controls.Add(this.txtCores);
            this.Controls.Add(this.btnCorTexto);
            this.Controls.Add(this.btnCorFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCorFundo;
        private System.Windows.Forms.Button btnCorTexto;
        private System.Windows.Forms.TextBox txtCores;
        private System.Windows.Forms.ColorDialog cdgCaixaCores;
    }
}

