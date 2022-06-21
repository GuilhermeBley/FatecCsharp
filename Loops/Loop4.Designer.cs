namespace Loops
{
    partial class FormLoop4
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblInscrição = new System.Windows.Forms.Label();
            this.lblProdução = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskdtxtNumInscrição = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.mskdtxtProdução = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtSalario = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtgratificacoes = new System.Windows.Forms.MaskedTextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(13, 84);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(49, 18);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo";
            // 
            // lblInscrição
            // 
            this.lblInscrição.AutoSize = true;
            this.lblInscrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscrição.Location = new System.Drawing.Point(13, 136);
            this.lblInscrição.Name = "lblInscrição";
            this.lblInscrição.Size = new System.Drawing.Size(146, 18);
            this.lblInscrição.TabIndex = 2;
            this.lblInscrição.Text = "Número de inscrição";
            // 
            // lblProdução
            // 
            this.lblProdução.AutoSize = true;
            this.lblProdução.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdução.Location = new System.Drawing.Point(594, 40);
            this.lblProdução.Name = "lblProdução";
            this.lblProdução.Size = new System.Drawing.Size(73, 18);
            this.lblProdução.TabIndex = 3;
            this.lblProdução.Text = "Produção";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(594, 84);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(54, 18);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gratificações";
            // 
            // mskdtxtNumInscrição
            // 
            this.mskdtxtNumInscrição.Location = new System.Drawing.Point(161, 136);
            this.mskdtxtNumInscrição.Mask = "00000";
            this.mskdtxtNumInscrição.Name = "mskdtxtNumInscrição";
            this.mskdtxtNumInscrição.Size = new System.Drawing.Size(37, 20);
            this.mskdtxtNumInscrição.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(161, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(366, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(161, 85);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(366, 20);
            this.txtCargo.TabIndex = 2;
            // 
            // mskdtxtProdução
            // 
            this.mskdtxtProdução.Location = new System.Drawing.Point(696, 41);
            this.mskdtxtProdução.Mask = "999";
            this.mskdtxtProdução.Name = "mskdtxtProdução";
            this.mskdtxtProdução.Size = new System.Drawing.Size(37, 20);
            this.mskdtxtProdução.TabIndex = 6;
            // 
            // mskdtxtSalario
            // 
            this.mskdtxtSalario.Location = new System.Drawing.Point(696, 84);
            this.mskdtxtSalario.Mask = "99900.99";
            this.mskdtxtSalario.Name = "mskdtxtSalario";
            this.mskdtxtSalario.Size = new System.Drawing.Size(92, 20);
            this.mskdtxtSalario.TabIndex = 7;
            // 
            // mskdtxtgratificacoes
            // 
            this.mskdtxtgratificacoes.Location = new System.Drawing.Point(696, 137);
            this.mskdtxtgratificacoes.Mask = "99900.99";
            this.mskdtxtgratificacoes.Name = "mskdtxtgratificacoes";
            this.mskdtxtgratificacoes.Size = new System.Drawing.Size(92, 20);
            this.mskdtxtgratificacoes.TabIndex = 8;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(551, 234);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(182, 105);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calcular Salário Bruto";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frmIf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.mskdtxtgratificacoes);
            this.Controls.Add(this.mskdtxtSalario);
            this.Controls.Add(this.mskdtxtProdução);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mskdtxtNumInscrição);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblProdução);
            this.Controls.Add(this.lblInscrição);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblName);
            this.Name = "frmIf";
            this.Text = "IF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblInscrição;
        private System.Windows.Forms.Label lblProdução;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskdtxtNumInscrição;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.MaskedTextBox mskdtxtProdução;
        private System.Windows.Forms.MaskedTextBox mskdtxtSalario;
        private System.Windows.Forms.MaskedTextBox mskdtxtgratificacoes;
        private System.Windows.Forms.Button btnCalc;
    }
}