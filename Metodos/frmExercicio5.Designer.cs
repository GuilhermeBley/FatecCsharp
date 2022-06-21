namespace Metodos
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
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFim = new System.Windows.Forms.Label();
            this.btnSorteio = new System.Windows.Forms.Button();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtFim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(42, 64);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(46, 20);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Inicio";
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFim.Location = new System.Drawing.Point(42, 126);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(35, 20);
            this.lblFim.TabIndex = 1;
            this.lblFim.Text = "Fim";
            // 
            // btnSorteio
            // 
            this.btnSorteio.Location = new System.Drawing.Point(112, 178);
            this.btnSorteio.Name = "btnSorteio";
            this.btnSorteio.Size = new System.Drawing.Size(176, 59);
            this.btnSorteio.TabIndex = 2;
            this.btnSorteio.Text = "Sorteio";
            this.btnSorteio.UseVisualStyleBackColor = true;
            this.btnSorteio.Click += new System.EventHandler(this.btnSorteio_Click);
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(140, 66);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(212, 20);
            this.txtInicio.TabIndex = 3;
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(140, 128);
            this.txtFim.Name = "txtFim";
            this.txtFim.Size = new System.Drawing.Size(212, 20);
            this.txtFim.TabIndex = 4;
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFim);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.btnSorteio);
            this.Controls.Add(this.lblFim);
            this.Controls.Add(this.lblInicio);
            this.Name = "frmExercicio5";
            this.Text = "Exercicio 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Button btnSorteio;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtFim;
    }
}