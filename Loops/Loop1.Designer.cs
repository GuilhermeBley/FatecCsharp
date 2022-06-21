namespace Loops
{
    partial class FormLoop1
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
            this.rchtxtEntrada = new System.Windows.Forms.RichTextBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtEntrada
            // 
            this.rchtxtEntrada.Location = new System.Drawing.Point(43, 38);
            this.rchtxtEntrada.MaxLength = 100;
            this.rchtxtEntrada.Name = "rchtxtEntrada";
            this.rchtxtEntrada.Size = new System.Drawing.Size(692, 96);
            this.rchtxtEntrada.TabIndex = 0;
            this.rchtxtEntrada.Text = "";
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(65, 173);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(119, 89);
            this.btnFor.TabIndex = 1;
            this.btnFor.Text = "Espaços em branco (For)";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(334, 173);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(119, 89);
            this.btnWhile.TabIndex = 2;
            this.btnWhile.Text = "Par de letras (while)";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.Location = new System.Drawing.Point(598, 173);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(119, 89);
            this.btnForeach.TabIndex = 3;
            this.btnForeach.Text = "Letra R (Foreach)";
            this.btnForeach.UseVisualStyleBackColor = true;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // frmLoop1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.rchtxtEntrada);
            this.Name = "frmLoop1";
            this.Text = "Loop1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtEntrada;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnForeach;
    }
}