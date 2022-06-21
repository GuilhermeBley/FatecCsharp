namespace Triangulo
{
    partial class Form1
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
            this.lblTamanho1 = new System.Windows.Forms.Label();
            this.lblTamanho2 = new System.Windows.Forms.Label();
            this.lblTamanho3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTamanho3 = new System.Windows.Forms.TextBox();
            this.txtTamanho2 = new System.Windows.Forms.TextBox();
            this.txtTamanho1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTamanho1
            // 
            this.lblTamanho1.AutoSize = true;
            this.lblTamanho1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho1.Location = new System.Drawing.Point(39, 63);
            this.lblTamanho1.Name = "lblTamanho1";
            this.lblTamanho1.Size = new System.Drawing.Size(106, 24);
            this.lblTamanho1.TabIndex = 0;
            this.lblTamanho1.Text = "Tamanho 1";
            // 
            // lblTamanho2
            // 
            this.lblTamanho2.AutoSize = true;
            this.lblTamanho2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho2.Location = new System.Drawing.Point(39, 154);
            this.lblTamanho2.Name = "lblTamanho2";
            this.lblTamanho2.Size = new System.Drawing.Size(106, 24);
            this.lblTamanho2.TabIndex = 1;
            this.lblTamanho2.Text = "Tamanho 2";
            // 
            // lblTamanho3
            // 
            this.lblTamanho3.AutoSize = true;
            this.lblTamanho3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho3.Location = new System.Drawing.Point(39, 255);
            this.lblTamanho3.Name = "lblTamanho3";
            this.lblTamanho3.Size = new System.Drawing.Size(106, 24);
            this.lblTamanho3.TabIndex = 2;
            this.lblTamanho3.Text = "Tamanho 3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(516, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 83);
            this.button1.TabIndex = 6;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(516, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 83);
            this.button2.TabIndex = 7;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTamanho3
            // 
            this.txtTamanho3.Location = new System.Drawing.Point(201, 260);
            this.txtTamanho3.Name = "txtTamanho3";
            this.txtTamanho3.Size = new System.Drawing.Size(149, 20);
            this.txtTamanho3.TabIndex = 5;
            // 
            // txtTamanho2
            // 
            this.txtTamanho2.Location = new System.Drawing.Point(201, 159);
            this.txtTamanho2.Name = "txtTamanho2";
            this.txtTamanho2.Size = new System.Drawing.Size(149, 20);
            this.txtTamanho2.TabIndex = 4;
            // 
            // txtTamanho1
            // 
            this.txtTamanho1.Location = new System.Drawing.Point(201, 66);
            this.txtTamanho1.Name = "txtTamanho1";
            this.txtTamanho1.Size = new System.Drawing.Size(149, 20);
            this.txtTamanho1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTamanho3);
            this.Controls.Add(this.txtTamanho2);
            this.Controls.Add(this.txtTamanho1);
            this.Controls.Add(this.lblTamanho3);
            this.Controls.Add(this.lblTamanho2);
            this.Controls.Add(this.lblTamanho1);
            this.Name = "Form1";
            this.Text = "Verificador de Triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTamanho1;
        private System.Windows.Forms.Label lblTamanho2;
        private System.Windows.Forms.Label lblTamanho3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTamanho3;
        private System.Windows.Forms.TextBox txtTamanho2;
        private System.Windows.Forms.TextBox txtTamanho1;
    }
}
