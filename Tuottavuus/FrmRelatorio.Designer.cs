namespace Tuottavuus
{
    partial class FrmRelatorio
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
            this.CbxItensRelatorio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbListAtividade = new System.Windows.Forms.CheckBox();
            this.CbxDepartamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxEmpregado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MktCompInicio = new System.Windows.Forms.MaskedTextBox();
            this.MktComFinal = new System.Windows.Forms.MaskedTextBox();
            this.MktCompetencia = new System.Windows.Forms.MaskedTextBox();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.RbDepartamento = new System.Windows.Forms.RadioButton();
            this.RbEmpregado = new System.Windows.Forms.RadioButton();
            this.RbEmpresa = new System.Windows.Forms.RadioButton();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxItensRelatorio
            // 
            this.CbxItensRelatorio.FormattingEnabled = true;
            this.CbxItensRelatorio.IntegralHeight = false;
            this.CbxItensRelatorio.Items.AddRange(new object[] {
            "01 - Calculos Produtividade",
            "02 - Avaliação Produtividade",
            "03 - Avaliar Produtividade",
            "04 - Avaliação Atividade"});
            this.CbxItensRelatorio.Location = new System.Drawing.Point(12, 27);
            this.CbxItensRelatorio.Name = "CbxItensRelatorio";
            this.CbxItensRelatorio.Size = new System.Drawing.Size(216, 21);
            this.CbxItensRelatorio.TabIndex = 0;
            this.CbxItensRelatorio.SelectedIndexChanged += new System.EventHandler(this.CbxItensRelatorio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o tipo de relatório";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbListAtividade);
            this.groupBox1.Controls.Add(this.CbxDepartamento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CbxEmpregado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MktCompInicio);
            this.groupBox1.Controls.Add(this.MktComFinal);
            this.groupBox1.Controls.Add(this.MktCompetencia);
            this.groupBox1.Controls.Add(this.CbxEmpresa);
            this.groupBox1.Controls.Add(this.RbDepartamento);
            this.groupBox1.Controls.Add(this.RbEmpregado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RbEmpresa);
            this.groupBox1.Location = new System.Drawing.Point(15, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // CbListAtividade
            // 
            this.CbListAtividade.AutoSize = true;
            this.CbListAtividade.Location = new System.Drawing.Point(88, 44);
            this.CbListAtividade.Name = "CbListAtividade";
            this.CbListAtividade.Size = new System.Drawing.Size(98, 17);
            this.CbListAtividade.TabIndex = 11;
            this.CbListAtividade.Text = "Listar Atividade";
            this.CbListAtividade.UseVisualStyleBackColor = true;
            this.CbListAtividade.Visible = false;
            // 
            // CbxDepartamento
            // 
            this.CbxDepartamento.DisplayMember = "Descricao";
            this.CbxDepartamento.Enabled = false;
            this.CbxDepartamento.FormattingEnabled = true;
            this.CbxDepartamento.IntegralHeight = false;
            this.CbxDepartamento.Location = new System.Drawing.Point(6, 144);
            this.CbxDepartamento.Name = "CbxDepartamento";
            this.CbxDepartamento.Size = new System.Drawing.Size(310, 21);
            this.CbxDepartamento.TabIndex = 10;
            this.CbxDepartamento.ValueMember = "Descricao";
            this.CbxDepartamento.SelectedIndexChanged += new System.EventHandler(this.CbxDepartamento_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Departamento";
            // 
            // CbxEmpregado
            // 
            this.CbxEmpregado.DisplayMember = "Nome";
            this.CbxEmpregado.Enabled = false;
            this.CbxEmpregado.FormattingEnabled = true;
            this.CbxEmpregado.IntegralHeight = false;
            this.CbxEmpregado.Location = new System.Drawing.Point(6, 104);
            this.CbxEmpregado.Name = "CbxEmpregado";
            this.CbxEmpregado.Size = new System.Drawing.Size(310, 21);
            this.CbxEmpregado.TabIndex = 8;
            this.CbxEmpregado.ValueMember = "Nome";
            this.CbxEmpregado.SelectedIndexChanged += new System.EventHandler(this.CbxEmpregado_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Empregado";
            // 
            // MktCompInicio
            // 
            this.MktCompInicio.Location = new System.Drawing.Point(192, 41);
            this.MktCompInicio.Mask = "00/0000";
            this.MktCompInicio.Name = "MktCompInicio";
            this.MktCompInicio.Size = new System.Drawing.Size(59, 20);
            this.MktCompInicio.TabIndex = 6;
            this.MktCompInicio.ValidatingType = typeof(System.DateTime);
            this.MktCompInicio.Visible = false;
            // 
            // MktComFinal
            // 
            this.MktComFinal.Location = new System.Drawing.Point(257, 41);
            this.MktComFinal.Mask = "00/0000";
            this.MktComFinal.Name = "MktComFinal";
            this.MktComFinal.Size = new System.Drawing.Size(59, 20);
            this.MktComFinal.TabIndex = 6;
            this.MktComFinal.ValidatingType = typeof(System.DateTime);
            this.MktComFinal.Visible = false;
            // 
            // MktCompetencia
            // 
            this.MktCompetencia.Location = new System.Drawing.Point(257, 18);
            this.MktCompetencia.Mask = "00/0000";
            this.MktCompetencia.Name = "MktCompetencia";
            this.MktCompetencia.Size = new System.Drawing.Size(59, 20);
            this.MktCompetencia.TabIndex = 6;
            this.MktCompetencia.ValidatingType = typeof(System.DateTime);
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.IntegralHeight = false;
            this.CbxEmpresa.Location = new System.Drawing.Point(6, 64);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(310, 21);
            this.CbxEmpresa.TabIndex = 5;
            this.CbxEmpresa.ValueMember = "Nome";
            this.CbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbxEmpresa_SelectedIndexChanged);
            // 
            // RbDepartamento
            // 
            this.RbDepartamento.AutoSize = true;
            this.RbDepartamento.Location = new System.Drawing.Point(163, 19);
            this.RbDepartamento.Name = "RbDepartamento";
            this.RbDepartamento.Size = new System.Drawing.Size(92, 17);
            this.RbDepartamento.TabIndex = 3;
            this.RbDepartamento.Text = "Departamento";
            this.RbDepartamento.UseVisualStyleBackColor = true;
            this.RbDepartamento.CheckedChanged += new System.EventHandler(this.RbDepartamento_CheckedChanged);
            // 
            // RbEmpregado
            // 
            this.RbEmpregado.AutoSize = true;
            this.RbEmpregado.Location = new System.Drawing.Point(78, 19);
            this.RbEmpregado.Name = "RbEmpregado";
            this.RbEmpregado.Size = new System.Drawing.Size(79, 17);
            this.RbEmpregado.TabIndex = 3;
            this.RbEmpregado.Text = "Empregado";
            this.RbEmpregado.UseVisualStyleBackColor = true;
            this.RbEmpregado.CheckedChanged += new System.EventHandler(this.RbEmpregado_CheckedChanged);
            // 
            // RbEmpresa
            // 
            this.RbEmpresa.AutoSize = true;
            this.RbEmpresa.Checked = true;
            this.RbEmpresa.Location = new System.Drawing.Point(6, 19);
            this.RbEmpresa.Name = "RbEmpresa";
            this.RbEmpresa.Size = new System.Drawing.Size(66, 17);
            this.RbEmpresa.TabIndex = 3;
            this.RbEmpresa.TabStop = true;
            this.RbEmpresa.Text = "Empresa";
            this.RbEmpresa.UseVisualStyleBackColor = true;
            this.RbEmpresa.CheckedChanged += new System.EventHandler(this.RbEmpresa_CheckedChanged);
            // 
            // BtnGerar
            // 
            this.BtnGerar.Location = new System.Drawing.Point(234, 25);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(104, 25);
            this.BtnGerar.TabIndex = 4;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = true;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 247);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxItensRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRelatorio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxItensRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbEmpregado;
        private System.Windows.Forms.RadioButton RbEmpresa;
        private System.Windows.Forms.MaskedTextBox MktCompetencia;
        private System.Windows.Forms.ComboBox CbxEmpresa;
        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxEmpregado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxDepartamento;
        private System.Windows.Forms.RadioButton RbDepartamento;
        private System.Windows.Forms.MaskedTextBox MktCompInicio;
        private System.Windows.Forms.MaskedTextBox MktComFinal;
        private System.Windows.Forms.CheckBox CbListAtividade;
    }
}