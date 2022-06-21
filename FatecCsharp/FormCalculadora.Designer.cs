namespace Calculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button1Soma = new System.Windows.Forms.Button();
            this.button2Sub = new System.Windows.Forms.Button();
            this.button3Div = new System.Windows.Forms.Button();
            this.button4Mul = new System.Windows.Forms.Button();
            this.button1Limpar = new System.Windows.Forms.Button();
            this.button1Sair = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero1.Location = new System.Drawing.Point(120, 36);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(78, 20);
            this.lblNumero1.TabIndex = 10;
            this.lblNumero1.Text = "Numero 1";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero2.Location = new System.Drawing.Point(120, 120);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(78, 20);
            this.lblNumero2.TabIndex = 11;
            this.lblNumero2.Text = "Numero 2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(120, 203);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(227, 121);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(225, 20);
            this.txtNumero2.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(227, 202);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(225, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // button1Soma
            // 
            this.button1Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Soma.Location = new System.Drawing.Point(37, 264);
            this.button1Soma.Name = "button1Soma";
            this.button1Soma.Size = new System.Drawing.Size(108, 73);
            this.button1Soma.TabIndex = 4;
            this.button1Soma.Text = "+";
            this.button1Soma.UseVisualStyleBackColor = true;
            this.button1Soma.Click += new System.EventHandler(this.button1Soma_Click);
            // 
            // button2Sub
            // 
            this.button2Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Sub.Location = new System.Drawing.Point(213, 264);
            this.button2Sub.Name = "button2Sub";
            this.button2Sub.Size = new System.Drawing.Size(108, 73);
            this.button2Sub.TabIndex = 5;
            this.button2Sub.Text = "-";
            this.button2Sub.UseVisualStyleBackColor = true;
            this.button2Sub.Click += new System.EventHandler(this.button2Sub_Click);
            // 
            // button3Div
            // 
            this.button3Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Div.Location = new System.Drawing.Point(390, 264);
            this.button3Div.Name = "button3Div";
            this.button3Div.Size = new System.Drawing.Size(108, 73);
            this.button3Div.TabIndex = 6;
            this.button3Div.Text = "/";
            this.button3Div.UseVisualStyleBackColor = true;
            this.button3Div.Click += new System.EventHandler(this.button3Div_Click);
            // 
            // button4Mul
            // 
            this.button4Mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4Mul.Location = new System.Drawing.Point(568, 264);
            this.button4Mul.Name = "button4Mul";
            this.button4Mul.Size = new System.Drawing.Size(108, 73);
            this.button4Mul.TabIndex = 7;
            this.button4Mul.Text = "*";
            this.button4Mul.UseVisualStyleBackColor = true;
            this.button4Mul.Click += new System.EventHandler(this.button4Mul_Click);
            // 
            // button1Limpar
            // 
            this.button1Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Limpar.Location = new System.Drawing.Point(552, 38);
            this.button1Limpar.Name = "button1Limpar";
            this.button1Limpar.Size = new System.Drawing.Size(167, 47);
            this.button1Limpar.TabIndex = 8;
            this.button1Limpar.Text = "Limpar";
            this.button1Limpar.UseVisualStyleBackColor = true;
            this.button1Limpar.Click += new System.EventHandler(this.button1Limpar_Click);
            // 
            // button1Sair
            // 
            this.button1Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Sair.Location = new System.Drawing.Point(552, 145);
            this.button1Sair.Name = "button1Sair";
            this.button1Sair.Size = new System.Drawing.Size(167, 47);
            this.button1Sair.TabIndex = 9;
            this.button1Sair.Text = "Sair";
            this.button1Sair.UseVisualStyleBackColor = true;
            this.button1Sair.Click += new System.EventHandler(this.button1Sair_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(227, 37);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(225, 20);
            this.txtNumero1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1Sair);
            this.Controls.Add(this.button1Limpar);
            this.Controls.Add(this.button4Mul);
            this.Controls.Add(this.button3Div);
            this.Controls.Add(this.button2Sub);
            this.Controls.Add(this.button1Soma);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button button1Soma;
        private System.Windows.Forms.Button button2Sub;
        private System.Windows.Forms.Button button3Div;
        private System.Windows.Forms.Button button4Mul;
        private System.Windows.Forms.Button button1Limpar;
        private System.Windows.Forms.Button button1Sair;
        private System.Windows.Forms.TextBox txtNumero1;
    }
}
