namespace Metodos
{
    partial class frmExercicio3
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
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnRemoveOcorrencias = new System.Windows.Forms.Button();
            this.btnRemoveOcorrenciasReplace = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra1.Location = new System.Drawing.Point(40, 44);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(69, 18);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra2.Location = new System.Drawing.Point(40, 120);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(69, 18);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(171, 45);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(245, 20);
            this.txtPalavra1.TabIndex = 2;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(171, 118);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(245, 20);
            this.txtPalavra2.TabIndex = 3;
            // 
            // btnRemoveOcorrencias
            // 
            this.btnRemoveOcorrencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOcorrencias.Location = new System.Drawing.Point(34, 214);
            this.btnRemoveOcorrencias.Name = "btnRemoveOcorrencias";
            this.btnRemoveOcorrencias.Size = new System.Drawing.Size(144, 89);
            this.btnRemoveOcorrencias.TabIndex = 4;
            this.btnRemoveOcorrencias.Text = "Remove ocorrências";
            this.btnRemoveOcorrencias.UseVisualStyleBackColor = true;
            this.btnRemoveOcorrencias.Click += new System.EventHandler(this.btnRemoveOcorrencias_Click);
            // 
            // btnRemoveOcorrenciasReplace
            // 
            this.btnRemoveOcorrenciasReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOcorrenciasReplace.Location = new System.Drawing.Point(321, 214);
            this.btnRemoveOcorrenciasReplace.Name = "btnRemoveOcorrenciasReplace";
            this.btnRemoveOcorrenciasReplace.Size = new System.Drawing.Size(144, 89);
            this.btnRemoveOcorrenciasReplace.TabIndex = 5;
            this.btnRemoveOcorrenciasReplace.Text = "Remove ocorrências (replace)";
            this.btnRemoveOcorrenciasReplace.UseVisualStyleBackColor = true;
            this.btnRemoveOcorrenciasReplace.Click += new System.EventHandler(this.btnRemoveOcorrenciasReplace_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverse.Location = new System.Drawing.Point(605, 214);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(144, 89);
            this.btnInverse.TabIndex = 6;
            this.btnInverse.Text = "Inverte (Reverse)";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnRemoveOcorrenciasReplace);
            this.Controls.Add(this.btnRemoveOcorrencias);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "frmExercicio3";
            this.Text = "Exercício 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnRemoveOcorrencias;
        private System.Windows.Forms.Button btnRemoveOcorrenciasReplace;
        private System.Windows.Forms.Button btnInverse;
    }
}