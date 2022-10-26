namespace Tuottavuus
{
    partial class FrmConsultaAssiduidade
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MktCompetencia = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvAssiduidade = new System.Windows.Forms.DataGridView();
            this.LblInfoAssiduidade = new System.Windows.Forms.Label();
            this.Id_Empregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtrasoFalta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssiduidade)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.Location = new System.Drawing.Point(12, 77);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(276, 21);
            this.CbxEmpresa.TabIndex = 11;
            this.CbxEmpresa.ValueMember = "Id";
            this.CbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbxEmpresa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Empresa";
            // 
            // MktCompetencia
            // 
            this.MktCompetencia.Location = new System.Drawing.Point(12, 25);
            this.MktCompetencia.Mask = "00/0000";
            this.MktCompetencia.Name = "MktCompetencia";
            this.MktCompetencia.Size = new System.Drawing.Size(69, 20);
            this.MktCompetencia.TabIndex = 9;
            this.MktCompetencia.Leave += new System.EventHandler(this.MktCompetencia_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Competência";
            // 
            // DgvAssiduidade
            // 
            this.DgvAssiduidade.AllowUserToAddRows = false;
            this.DgvAssiduidade.AllowUserToDeleteRows = false;
            this.DgvAssiduidade.AllowUserToOrderColumns = true;
            this.DgvAssiduidade.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvAssiduidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvAssiduidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAssiduidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Empregado,
            this.Nome,
            this.AtrasoFalta});
            this.DgvAssiduidade.Location = new System.Drawing.Point(12, 136);
            this.DgvAssiduidade.MultiSelect = false;
            this.DgvAssiduidade.Name = "DgvAssiduidade";
            this.DgvAssiduidade.ReadOnly = true;
            this.DgvAssiduidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAssiduidade.Size = new System.Drawing.Size(354, 150);
            this.DgvAssiduidade.TabIndex = 12;
            // 
            // LblInfoAssiduidade
            // 
            this.LblInfoAssiduidade.AutoSize = true;
            this.LblInfoAssiduidade.Location = new System.Drawing.Point(12, 120);
            this.LblInfoAssiduidade.Name = "LblInfoAssiduidade";
            this.LblInfoAssiduidade.Size = new System.Drawing.Size(85, 13);
            this.LblInfoAssiduidade.TabIndex = 13;
            this.LblInfoAssiduidade.Text = "Assiduidade - 00";
            // 
            // Id_Empregado
            // 
            this.Id_Empregado.DataPropertyName = "Id_Empregado";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Id_Empregado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Id_Empregado.HeaderText = "Id_Empregado";
            this.Id_Empregado.Name = "Id_Empregado";
            this.Id_Empregado.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 180;
            // 
            // AtrasoFalta
            // 
            this.AtrasoFalta.DataPropertyName = "AtrasoFalta";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.AtrasoFalta.DefaultCellStyle = dataGridViewCellStyle4;
            this.AtrasoFalta.HeaderText = "Atraso / Falta";
            this.AtrasoFalta.Name = "AtrasoFalta";
            this.AtrasoFalta.ReadOnly = true;
            // 
            // FrmConsultaAssiduidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 296);
            this.Controls.Add(this.LblInfoAssiduidade);
            this.Controls.Add(this.DgvAssiduidade);
            this.Controls.Add(this.CbxEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MktCompetencia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaAssiduidade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Assiduidade";
            this.Load += new System.EventHandler(this.FrmConsultaAssiduidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssiduidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MktCompetencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvAssiduidade;
        private System.Windows.Forms.Label LblInfoAssiduidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Empregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtrasoFalta;
    }
}