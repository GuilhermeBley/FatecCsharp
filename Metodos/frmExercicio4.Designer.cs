namespace Metodos
{
    partial class frmExercicio4
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
            this.richtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnNumerico = new System.Windows.Forms.Button();
            this.btnEspacoBranco = new System.Windows.Forms.Button();
            this.btnAlfabeticos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richtxtTexto
            // 
            this.richtxtTexto.Location = new System.Drawing.Point(33, 27);
            this.richtxtTexto.Name = "richtxtTexto";
            this.richtxtTexto.Size = new System.Drawing.Size(728, 142);
            this.richtxtTexto.TabIndex = 0;
            this.richtxtTexto.Text = "";
            // 
            // btnNumerico
            // 
            this.btnNumerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumerico.Location = new System.Drawing.Point(69, 193);
            this.btnNumerico.Name = "btnNumerico";
            this.btnNumerico.Size = new System.Drawing.Size(153, 117);
            this.btnNumerico.TabIndex = 1;
            this.btnNumerico.Text = "Numérico";
            this.btnNumerico.UseVisualStyleBackColor = true;
            this.btnNumerico.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnEspacoBranco
            // 
            this.btnEspacoBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspacoBranco.Location = new System.Drawing.Point(317, 193);
            this.btnEspacoBranco.Name = "btnEspacoBranco";
            this.btnEspacoBranco.Size = new System.Drawing.Size(153, 117);
            this.btnEspacoBranco.TabIndex = 2;
            this.btnEspacoBranco.Text = "Posição primeiro espaço em branco";
            this.btnEspacoBranco.UseVisualStyleBackColor = true;
            this.btnEspacoBranco.Click += new System.EventHandler(this.btnEspacoBranco_Click);
            // 
            // btnAlfabeticos
            // 
            this.btnAlfabeticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlfabeticos.Location = new System.Drawing.Point(556, 193);
            this.btnAlfabeticos.Name = "btnAlfabeticos";
            this.btnAlfabeticos.Size = new System.Drawing.Size(153, 117);
            this.btnAlfabeticos.TabIndex = 3;
            this.btnAlfabeticos.Text = "Alfabéticos";
            this.btnAlfabeticos.UseVisualStyleBackColor = true;
            this.btnAlfabeticos.Click += new System.EventHandler(this.btnAlfabeticos_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlfabeticos);
            this.Controls.Add(this.btnEspacoBranco);
            this.Controls.Add(this.btnNumerico);
            this.Controls.Add(this.richtxtTexto);
            this.Name = "frmExercicio4";
            this.Text = "Exercicio 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtTexto;
        private System.Windows.Forms.Button btnNumerico;
        private System.Windows.Forms.Button btnEspacoBranco;
        private System.Windows.Forms.Button btnAlfabeticos;
    }
}