namespace Funcionario
{
    partial class FormFuncionario
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
            this.lblNomeFuncionário = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.btnVerificarDesconto = new System.Windows.Forms.Button();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.mskbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskbxNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.lblSalarioFami = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDesontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.btnOff = new System.Windows.Forms.Button();
            this.mskbxNomeFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliquotaINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliquotaIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalarioFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalarioLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescontoINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescontoIRPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblNomeFuncionário
            // 
            this.lblNomeFuncionário.AutoSize = true;
            this.lblNomeFuncionário.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionário.Location = new System.Drawing.Point(28, 31);
            this.lblNomeFuncionário.Name = "lblNomeFuncionário";
            this.lblNomeFuncionário.Size = new System.Drawing.Size(126, 18);
            this.lblNomeFuncionário.TabIndex = 0;
            this.lblNomeFuncionário.Text = "Nome funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(28, 86);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(92, 18);
            this.lblSalarioBruto.TabIndex = 1;
            this.lblSalarioBruto.Text = "Salário bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFilhos.Location = new System.Drawing.Point(28, 141);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(121, 18);
            this.lblNumFilhos.TabIndex = 2;
            this.lblNumFilhos.Text = "Número de filhos";
            // 
            // btnVerificarDesconto
            // 
            this.btnVerificarDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarDesconto.Location = new System.Drawing.Point(207, 191);
            this.btnVerificarDesconto.Name = "btnVerificarDesconto";
            this.btnVerificarDesconto.Size = new System.Drawing.Size(163, 27);
            this.btnVerificarDesconto.TabIndex = 3;
            this.btnVerificarDesconto.Text = "Verificar desconto";
            this.btnVerificarDesconto.UseVisualStyleBackColor = true;
            this.btnVerificarDesconto.Click += new System.EventHandler(this.btnVerificarDesconto_Click);
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Checked = true;
            this.rbtnMasc.Location = new System.Drawing.Point(677, 62);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(68, 17);
            this.rbtnMasc.TabIndex = 4;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Maculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(677, 89);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(67, 17);
            this.rbtnFem.TabIndex = 5;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // mskbxSalarioBruto
            // 
            this.mskbxSalarioBruto.Location = new System.Drawing.Point(197, 86);
            this.mskbxSalarioBruto.Mask = "00000.00";
            this.mskbxSalarioBruto.Name = "mskbxSalarioBruto";
            this.mskbxSalarioBruto.Size = new System.Drawing.Size(100, 20);
            this.mskbxSalarioBruto.TabIndex = 6;
            // 
            // mskbxNumFilhos
            // 
            this.mskbxNumFilhos.Location = new System.Drawing.Point(197, 139);
            this.mskbxNumFilhos.Mask = "00";
            this.mskbxNumFilhos.Name = "mskbxNumFilhos";
            this.mskbxNumFilhos.Size = new System.Drawing.Size(100, 20);
            this.mskbxNumFilhos.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexo";
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(677, 144);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(62, 17);
            this.ckbxCasado.TabIndex = 10;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(28, 243);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado";
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliquotaINSS.Location = new System.Drawing.Point(28, 285);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(98, 18);
            this.lblAliquotaINSS.TabIndex = 12;
            this.lblAliquotaINSS.Text = "Aliquota INSS";
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(28, 326);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(97, 18);
            this.lblAliquotaIRPF.TabIndex = 13;
            this.lblAliquotaIRPF.Text = "Aliquota IRPF";
            // 
            // lblSalarioFami
            // 
            this.lblSalarioFami.AutoSize = true;
            this.lblSalarioFami.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFami.Location = new System.Drawing.Point(28, 368);
            this.lblSalarioFami.Name = "lblSalarioFami";
            this.lblSalarioFami.Size = new System.Drawing.Size(100, 18);
            this.lblSalarioFami.TabIndex = 14;
            this.lblSalarioFami.Text = "Salário família";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(28, 408);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(105, 18);
            this.lblSalarioLiquido.TabIndex = 15;
            this.lblSalarioLiquido.Text = "Salario Líquido";
            // 
            // lblDesontoINSS
            // 
            this.lblDesontoINSS.AutoSize = true;
            this.lblDesontoINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesontoINSS.Location = new System.Drawing.Point(424, 286);
            this.lblDesontoINSS.Name = "lblDesontoINSS";
            this.lblDesontoINSS.Size = new System.Drawing.Size(111, 18);
            this.lblDesontoINSS.TabIndex = 20;
            this.lblDesontoINSS.Text = "Desconto INSS";
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoIRPF.Location = new System.Drawing.Point(424, 325);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(110, 18);
            this.lblDescontoIRPF.TabIndex = 21;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(677, 409);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(42, 36);
            this.btnOff.TabIndex = 24;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // mskbxNomeFuncionario
            // 
            this.mskbxNomeFuncionario.Location = new System.Drawing.Point(197, 28);
            this.mskbxNomeFuncionario.Name = "mskbxNomeFuncionario";
            this.mskbxNomeFuncionario.Size = new System.Drawing.Size(315, 20);
            this.mskbxNomeFuncionario.TabIndex = 25;
            // 
            // mskbxAliquotaINSS
            // 
            this.mskbxAliquotaINSS.Enabled = false;
            this.mskbxAliquotaINSS.Location = new System.Drawing.Point(160, 285);
            this.mskbxAliquotaINSS.Name = "mskbxAliquotaINSS";
            this.mskbxAliquotaINSS.Size = new System.Drawing.Size(118, 20);
            this.mskbxAliquotaINSS.TabIndex = 26;
            // 
            // mskbxAliquotaIRPF
            // 
            this.mskbxAliquotaIRPF.Enabled = false;
            this.mskbxAliquotaIRPF.Location = new System.Drawing.Point(160, 327);
            this.mskbxAliquotaIRPF.Name = "mskbxAliquotaIRPF";
            this.mskbxAliquotaIRPF.Size = new System.Drawing.Size(118, 20);
            this.mskbxAliquotaIRPF.TabIndex = 27;
            // 
            // mskbxSalarioFamilia
            // 
            this.mskbxSalarioFamilia.Enabled = false;
            this.mskbxSalarioFamilia.Location = new System.Drawing.Point(160, 368);
            this.mskbxSalarioFamilia.Name = "mskbxSalarioFamilia";
            this.mskbxSalarioFamilia.Size = new System.Drawing.Size(118, 20);
            this.mskbxSalarioFamilia.TabIndex = 28;
            // 
            // mskbxSalarioLiquido
            // 
            this.mskbxSalarioLiquido.Enabled = false;
            this.mskbxSalarioLiquido.Location = new System.Drawing.Point(160, 408);
            this.mskbxSalarioLiquido.Name = "mskbxSalarioLiquido";
            this.mskbxSalarioLiquido.ReadOnly = true;
            this.mskbxSalarioLiquido.Size = new System.Drawing.Size(118, 20);
            this.mskbxSalarioLiquido.TabIndex = 29;
            // 
            // mskbxDescontoINSS
            // 
            this.mskbxDescontoINSS.Enabled = false;
            this.mskbxDescontoINSS.Location = new System.Drawing.Point(553, 287);
            this.mskbxDescontoINSS.Name = "mskbxDescontoINSS";
            this.mskbxDescontoINSS.Size = new System.Drawing.Size(118, 20);
            this.mskbxDescontoINSS.TabIndex = 30;
            // 
            // mskbxDescontoIRPF
            // 
            this.mskbxDescontoIRPF.Enabled = false;
            this.mskbxDescontoIRPF.Location = new System.Drawing.Point(553, 324);
            this.mskbxDescontoIRPF.Name = "mskbxDescontoIRPF";
            this.mskbxDescontoIRPF.Size = new System.Drawing.Size(118, 20);
            this.mskbxDescontoIRPF.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskbxDescontoIRPF);
            this.Controls.Add(this.mskbxDescontoINSS);
            this.Controls.Add(this.mskbxSalarioLiquido);
            this.Controls.Add(this.mskbxSalarioFamilia);
            this.Controls.Add(this.mskbxAliquotaIRPF);
            this.Controls.Add(this.mskbxAliquotaINSS);
            this.Controls.Add(this.mskbxNomeFuncionario);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.lblDesontoINSS);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFami);
            this.Controls.Add(this.lblAliquotaIRPF);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.ckbxCasado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskbxNumFilhos);
            this.Controls.Add(this.mskbxSalarioBruto);
            this.Controls.Add(this.rbtnFem);
            this.Controls.Add(this.rbtnMasc);
            this.Controls.Add(this.btnVerificarDesconto);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNomeFuncionário);
            this.Name = "Form1";
            this.Text = "Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFuncionário;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.Button btnVerificarDesconto;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioBruto;
        private System.Windows.Forms.MaskedTextBox mskbxNumFilhos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.Label lblSalarioFami;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblDesontoINSS;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.MaskedTextBox mskbxNomeFuncionario;
        private System.Windows.Forms.MaskedTextBox mskbxAliquotaINSS;
        private System.Windows.Forms.MaskedTextBox mskbxAliquotaIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioLiquido;
        private System.Windows.Forms.MaskedTextBox mskbxDescontoINSS;
        private System.Windows.Forms.MaskedTextBox mskbxDescontoIRPF;
    }
}
