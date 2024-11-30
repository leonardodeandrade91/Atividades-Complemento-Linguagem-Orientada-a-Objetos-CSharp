namespace InterfaceOrdenandoArrays {
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
            this.lblArr1N = new System.Windows.Forms.Label();
            this.lblArr2N = new System.Windows.Forms.Label();
            this.lblArr1O = new System.Windows.Forms.Label();
            this.lblArr2O = new System.Windows.Forms.Label();
            this.btnCrArr = new System.Windows.Forms.Button();
            this.btnOrdArr = new System.Windows.Forms.Button();
            this.btnOrdSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArr1N
            // 
            this.lblArr1N.AutoSize = true;
            this.lblArr1N.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArr1N.ForeColor = System.Drawing.Color.Maroon;
            this.lblArr1N.Location = new System.Drawing.Point(77, 135);
            this.lblArr1N.Name = "lblArr1N";
            this.lblArr1N.Size = new System.Drawing.Size(0, 18);
            this.lblArr1N.TabIndex = 0;
            // 
            // lblArr2N
            // 
            this.lblArr2N.AutoSize = true;
            this.lblArr2N.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArr2N.ForeColor = System.Drawing.Color.Maroon;
            this.lblArr2N.Location = new System.Drawing.Point(77, 191);
            this.lblArr2N.Name = "lblArr2N";
            this.lblArr2N.Size = new System.Drawing.Size(0, 18);
            this.lblArr2N.TabIndex = 1;
            // 
            // lblArr1O
            // 
            this.lblArr1O.AutoSize = true;
            this.lblArr1O.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArr1O.ForeColor = System.Drawing.Color.Navy;
            this.lblArr1O.Location = new System.Drawing.Point(77, 246);
            this.lblArr1O.Name = "lblArr1O";
            this.lblArr1O.Size = new System.Drawing.Size(0, 18);
            this.lblArr1O.TabIndex = 2;
            // 
            // lblArr2O
            // 
            this.lblArr2O.AutoSize = true;
            this.lblArr2O.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArr2O.ForeColor = System.Drawing.Color.Navy;
            this.lblArr2O.Location = new System.Drawing.Point(77, 297);
            this.lblArr2O.Name = "lblArr2O";
            this.lblArr2O.Size = new System.Drawing.Size(0, 18);
            this.lblArr2O.TabIndex = 3;
            // 
            // btnCrArr
            // 
            this.btnCrArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrArr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCrArr.Location = new System.Drawing.Point(43, 55);
            this.btnCrArr.Name = "btnCrArr";
            this.btnCrArr.Size = new System.Drawing.Size(132, 46);
            this.btnCrArr.TabIndex = 4;
            this.btnCrArr.Text = "Criar Array";
            this.btnCrArr.UseVisualStyleBackColor = true;
            this.btnCrArr.Click += new System.EventHandler(this.btnCrArr_Click);
            // 
            // btnOrdArr
            // 
            this.btnOrdArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdArr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOrdArr.Location = new System.Drawing.Point(214, 55);
            this.btnOrdArr.Name = "btnOrdArr";
            this.btnOrdArr.Size = new System.Drawing.Size(132, 46);
            this.btnOrdArr.TabIndex = 5;
            this.btnOrdArr.Text = "Ordenar Array";
            this.btnOrdArr.UseVisualStyleBackColor = true;
            this.btnOrdArr.Click += new System.EventHandler(this.btnOrdArr_Click);
            // 
            // btnOrdSort
            // 
            this.btnOrdSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOrdSort.Location = new System.Drawing.Point(379, 55);
            this.btnOrdSort.Name = "btnOrdSort";
            this.btnOrdSort.Size = new System.Drawing.Size(132, 46);
            this.btnOrdSort.TabIndex = 6;
            this.btnOrdSort.Text = "Ordenar Sort";
            this.btnOrdSort.UseVisualStyleBackColor = true;
            this.btnOrdSort.Click += new System.EventHandler(this.btnOrdSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 357);
            this.Controls.Add(this.btnOrdSort);
            this.Controls.Add(this.btnOrdArr);
            this.Controls.Add(this.btnCrArr);
            this.Controls.Add(this.lblArr2O);
            this.Controls.Add(this.lblArr1O);
            this.Controls.Add(this.lblArr2N);
            this.Controls.Add(this.lblArr1N);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenando Arrays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArr1N;
        private System.Windows.Forms.Label lblArr2N;
        private System.Windows.Forms.Label lblArr1O;
        private System.Windows.Forms.Label lblArr2O;
        private System.Windows.Forms.Button btnCrArr;
        private System.Windows.Forms.Button btnOrdArr;
        private System.Windows.Forms.Button btnOrdSort;
    }
}

