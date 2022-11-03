namespace Tuottavuus
{
    partial class FrmCadastroAfastamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CbxEmpregado = new System.Windows.Forms.ComboBox();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCompetencia = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.DgvAfastamento = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAfastamento)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxEmpregado
            // 
            this.CbxEmpregado.DisplayMember = "Nome";
            this.CbxEmpregado.FormattingEnabled = true;
            this.CbxEmpregado.Location = new System.Drawing.Point(12, 87);
            this.CbxEmpregado.Name = "CbxEmpregado";
            this.CbxEmpregado.Size = new System.Drawing.Size(214, 21);
            this.CbxEmpregado.TabIndex = 20;
            this.CbxEmpregado.ValueMember = "Id";
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.Location = new System.Drawing.Point(12, 47);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(214, 21);
            this.CbxEmpresa.TabIndex = 19;
            this.CbxEmpresa.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Empregado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Empresa";
            // 
            // LblCompetencia
            // 
            this.LblCompetencia.AutoSize = true;
            this.LblCompetencia.Location = new System.Drawing.Point(12, 9);
            this.LblCompetencia.Name = "LblCompetencia";
            this.LblCompetencia.Size = new System.Drawing.Size(116, 13);
            this.LblCompetencia.TabIndex = 21;
            this.LblCompetencia.Text = "Competência: 00/0000";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(250, 82);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(104, 29);
            this.BtnExcluir.TabIndex = 26;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(250, 47);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(104, 29);
            this.BtnAlterar.TabIndex = 25;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(250, 12);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(104, 29);
            this.BtnGravar.TabIndex = 24;
            this.BtnGravar.Text = "&Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            // 
            // DgvAfastamento
            // 
            this.DgvAfastamento.AllowUserToAddRows = false;
            this.DgvAfastamento.AllowUserToDeleteRows = false;
            this.DgvAfastamento.AllowUserToOrderColumns = true;
            this.DgvAfastamento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvAfastamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvAfastamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAfastamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Total_Dias});
            this.DgvAfastamento.Location = new System.Drawing.Point(12, 126);
            this.DgvAfastamento.Name = "DgvAfastamento";
            this.DgvAfastamento.ReadOnly = true;
            this.DgvAfastamento.Size = new System.Drawing.Size(342, 117);
            this.DgvAfastamento.TabIndex = 27;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Total_Dias
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Total_Dias.DefaultCellStyle = dataGridViewCellStyle1;
            this.Total_Dias.HeaderText = "Total_Dias";
            this.Total_Dias.Name = "Total_Dias";
            this.Total_Dias.ReadOnly = true;
            // 
            // FrmCadastroAfastamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 255);
            this.Controls.Add(this.DgvAfastamento);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.CbxEmpregado);
            this.Controls.Add(this.CbxEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblCompetencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCadastroAfastamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Afastamento";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAfastamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxEmpregado;
        private System.Windows.Forms.ComboBox CbxEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCompetencia;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.DataGridView DgvAfastamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Dias;
    }
}