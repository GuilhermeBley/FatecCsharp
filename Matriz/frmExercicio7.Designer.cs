namespace Matriz
{
    partial class frmExercicio7
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.mskdtxtboxRa = new System.Windows.Forms.MaskedTextBox();
            this.lstboxResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(127, 155);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(150, 98);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // mskdtxtboxRa
            // 
            this.mskdtxtboxRa.Location = new System.Drawing.Point(154, 129);
            this.mskdtxtboxRa.Mask = "0000000000000";
            this.mskdtxtboxRa.Name = "mskdtxtboxRa";
            this.mskdtxtboxRa.Size = new System.Drawing.Size(100, 20);
            this.mskdtxtboxRa.TabIndex = 1;
            // 
            // lstboxResults
            // 
            this.lstboxResults.FormattingEnabled = true;
            this.lstboxResults.Location = new System.Drawing.Point(471, 12);
            this.lstboxResults.Name = "lstboxResults";
            this.lstboxResults.Size = new System.Drawing.Size(298, 329);
            this.lstboxResults.TabIndex = 2;
            // 
            // frmExercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstboxResults);
            this.Controls.Add(this.mskdtxtboxRa);
            this.Controls.Add(this.btnExecutar);
            this.Name = "frmExercicio7";
            this.Text = "frmExercicio7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.MaskedTextBox mskdtxtboxRa;
        private System.Windows.Forms.ListBox lstboxResults;
    }
}