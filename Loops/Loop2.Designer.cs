namespace Loops
{
    partial class FormLoop2
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
            this.lblNumberN = new System.Windows.Forms.Label();
            this.txtNumeroN = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumberN
            // 
            this.lblNumberN.AutoSize = true;
            this.lblNumberN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberN.Location = new System.Drawing.Point(41, 54);
            this.lblNumberN.Name = "lblNumberN";
            this.lblNumberN.Size = new System.Drawing.Size(244, 24);
            this.lblNumberN.TabIndex = 0;
            this.lblNumberN.Text = "Digite o número N de vezes";
            // 
            // txtNumeroN
            // 
            this.txtNumeroN.Location = new System.Drawing.Point(359, 57);
            this.txtNumeroN.Name = "txtNumeroN";
            this.txtNumeroN.Size = new System.Drawing.Size(124, 20);
            this.txtNumeroN.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(176, 166);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(226, 117);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calcular H";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frmLoop2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtNumeroN);
            this.Controls.Add(this.lblNumberN);
            this.Name = "frmLoop2";
            this.Text = "Loop2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberN;
        private System.Windows.Forms.TextBox txtNumeroN;
        private System.Windows.Forms.Button btnCalc;
    }
}