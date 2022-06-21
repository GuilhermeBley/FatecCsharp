namespace Aval
{
    partial class FormAval
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
            this.lstbxResults = new System.Windows.Forms.ListBox();
            this.mskbxRa = new System.Windows.Forms.MaskedTextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbxResults
            // 
            this.lstbxResults.FormattingEnabled = true;
            this.lstbxResults.Location = new System.Drawing.Point(460, 24);
            this.lstbxResults.Name = "lstbxResults";
            this.lstbxResults.Size = new System.Drawing.Size(298, 329);
            this.lstbxResults.TabIndex = 2;
            // 
            // mskbxRa
            // 
            this.mskbxRa.Location = new System.Drawing.Point(161, 112);
            this.mskbxRa.Mask = "0000000000000";
            this.mskbxRa.Name = "mskbxRa";
            this.mskbxRa.Size = new System.Drawing.Size(100, 20);
            this.mskbxRa.TabIndex = 1;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(134, 156);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(150, 98);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.mskbxRa);
            this.Controls.Add(this.lstbxResults);
            this.Name = "Form1";
            this.Text = "Prova 24-11-2020";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxResults;
        private System.Windows.Forms.MaskedTextBox mskbxRa;
        private System.Windows.Forms.Button btnExecutar;
    }
}
