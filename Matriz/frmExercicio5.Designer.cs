namespace Matriz
{
    partial class frmExercicio5
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
            this.btnAlunos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(260, 114);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(223, 132);
            this.btnAlunos.TabIndex = 0;
            this.btnAlunos.Text = "Exibir lista final de alunos";
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlunos);
            this.Name = "frmExercicio5";
            this.RightToLeftLayout = true;
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlunos;
    }
}