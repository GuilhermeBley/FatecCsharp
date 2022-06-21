namespace PesoIdeal
{
    partial class FormPesoIdeal
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.radioButton1Masc = new System.Windows.Forms.RadioButton();
            this.radioButton2Fem = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.button1Calcular = new System.Windows.Forms.Button();
            this.button2Fechar = new System.Windows.Forms.Button();
            this.mskbxPeso = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(12, 57);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(97, 24);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso atual";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(12, 122);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(58, 24);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura";
            // 
            // radioButton1Masc
            // 
            this.radioButton1Masc.AutoSize = true;
            this.radioButton1Masc.Checked = true;
            this.radioButton1Masc.Location = new System.Drawing.Point(587, 99);
            this.radioButton1Masc.Name = "radioButton1Masc";
            this.radioButton1Masc.Size = new System.Drawing.Size(73, 17);
            this.radioButton1Masc.TabIndex = 4;
            this.radioButton1Masc.TabStop = true;
            this.radioButton1Masc.Text = "Masculino";
            this.radioButton1Masc.UseVisualStyleBackColor = true;
            // 
            // radioButton2Fem
            // 
            this.radioButton2Fem.AutoSize = true;
            this.radioButton2Fem.Location = new System.Drawing.Point(587, 122);
            this.radioButton2Fem.Name = "radioButton2Fem";
            this.radioButton2Fem.Size = new System.Drawing.Size(67, 17);
            this.radioButton2Fem.TabIndex = 6;
            this.radioButton2Fem.Text = "Feminino";
            this.radioButton2Fem.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(593, 57);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(54, 24);
            this.lblSexo.TabIndex = 7;
            this.lblSexo.Text = "Sexo";
            // 
            // button1Calcular
            // 
            this.button1Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Calcular.Location = new System.Drawing.Point(144, 267);
            this.button1Calcular.Name = "button1Calcular";
            this.button1Calcular.Size = new System.Drawing.Size(119, 80);
            this.button1Calcular.TabIndex = 8;
            this.button1Calcular.Text = "Calcular";
            this.button1Calcular.UseVisualStyleBackColor = true;
            this.button1Calcular.Click += new System.EventHandler(this.button1Calcular_Click);
            // 
            // button2Fechar
            // 
            this.button2Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Fechar.Location = new System.Drawing.Point(528, 267);
            this.button2Fechar.Name = "button2Fechar";
            this.button2Fechar.Size = new System.Drawing.Size(119, 80);
            this.button2Fechar.TabIndex = 9;
            this.button2Fechar.Text = "Fechar";
            this.button2Fechar.UseVisualStyleBackColor = true;
            this.button2Fechar.Click += new System.EventHandler(this.button2Fechar_Click);
            // 
            // mskbxPeso
            // 
            this.mskbxPeso.Location = new System.Drawing.Point(155, 62);
            this.mskbxPeso.Mask = "000.00";
            this.mskbxPeso.Name = "mskbxPeso";
            this.mskbxPeso.Size = new System.Drawing.Size(133, 20);
            this.mskbxPeso.TabIndex = 10;
            // 
            // mskbxAltura
            // 
            this.mskbxAltura.Location = new System.Drawing.Point(155, 119);
            this.mskbxAltura.Mask = "0.00";
            this.mskbxAltura.Name = "mskbxAltura";
            this.mskbxAltura.Size = new System.Drawing.Size(133, 20);
            this.mskbxAltura.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskbxAltura);
            this.Controls.Add(this.mskbxPeso);
            this.Controls.Add(this.button2Fechar);
            this.Controls.Add(this.button1Calcular);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.radioButton2Fem);
            this.Controls.Add(this.radioButton1Masc);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.RadioButton radioButton1Masc;
        private System.Windows.Forms.RadioButton radioButton2Fem;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Button button1Calcular;
        private System.Windows.Forms.Button button2Fechar;
        private System.Windows.Forms.MaskedTextBox mskbxPeso;
        private System.Windows.Forms.MaskedTextBox mskbxAltura;
    }
}
