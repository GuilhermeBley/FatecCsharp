namespace Metodos
{
    partial class frmExercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.btnTestarIguais = new System.Windows.Forms.Button();
            this.btnInserirPonto = new System.Windows.Forms.Button();
            this.btnInseriAsteristico = new System.Windows.Forms.Button();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(28, 27);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(28, 87);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(113, 27);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 2;
            // 
            // btnTestarIguais
            // 
            this.btnTestarIguais.Location = new System.Drawing.Point(31, 168);
            this.btnTestarIguais.Name = "btnTestarIguais";
            this.btnTestarIguais.Size = new System.Drawing.Size(80, 36);
            this.btnTestarIguais.TabIndex = 4;
            this.btnTestarIguais.Text = "Testar iguais";
            this.btnTestarIguais.UseVisualStyleBackColor = true;
            this.btnTestarIguais.Click += new System.EventHandler(this.btnTestarIguais_Click);
            // 
            // btnInserirPonto
            // 
            this.btnInserirPonto.Location = new System.Drawing.Point(184, 168);
            this.btnInserirPonto.Name = "btnInserirPonto";
            this.btnInserirPonto.Size = new System.Drawing.Size(81, 36);
            this.btnInserirPonto.TabIndex = 5;
            this.btnInserirPonto.Text = "Inseri primeiro no segundo";
            this.btnInserirPonto.UseVisualStyleBackColor = true;
            this.btnInserirPonto.Click += new System.EventHandler(this.btnInserirPonto_Click);
            // 
            // btnInseriAsteristico
            // 
            this.btnInseriAsteristico.Location = new System.Drawing.Point(334, 168);
            this.btnInseriAsteristico.Name = "btnInseriAsteristico";
            this.btnInseriAsteristico.Size = new System.Drawing.Size(94, 36);
            this.btnInseriAsteristico.TabIndex = 6;
            this.btnInseriAsteristico.Text = "Inseri asteristico";
            this.btnInseriAsteristico.UseVisualStyleBackColor = true;
            this.btnInseriAsteristico.Click += new System.EventHandler(this.btnInseriAsteristico_Click);
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(113, 87);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 7;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.btnInseriAsteristico);
            this.Controls.Add(this.btnInserirPonto);
            this.Controls.Add(this.btnTestarIguais);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "Exercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Button btnTestarIguais;
        private System.Windows.Forms.Button btnInserirPonto;
        private System.Windows.Forms.Button btnInseriAsteristico;
        private System.Windows.Forms.TextBox txtPalavra2;
    }
}