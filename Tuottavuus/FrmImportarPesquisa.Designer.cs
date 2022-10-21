namespace Tuottavuus
{
    partial class FrmImportarPesquisa
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
            this.LblCompetencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.BtnProcurar = new System.Windows.Forms.Button();
            this.BtnImportar = new System.Windows.Forms.Button();
            this.LblLayoutImportacao = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LblCompetencia
            // 
            this.LblCompetencia.AutoSize = true;
            this.LblCompetencia.Location = new System.Drawing.Point(13, 11);
            this.LblCompetencia.Name = "LblCompetencia";
            this.LblCompetencia.Size = new System.Drawing.Size(116, 13);
            this.LblCompetencia.TabIndex = 0;
            this.LblCompetencia.Text = "Competência: 00/0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empresa";
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.Location = new System.Drawing.Point(13, 56);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(286, 21);
            this.CbxEmpresa.TabIndex = 0;
            this.CbxEmpresa.ValueMember = "Id";
            this.CbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbxEmpresa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Caminho do arquivo";
            // 
            // TxtCaminhoArquivo
            // 
            this.TxtCaminhoArquivo.Location = new System.Drawing.Point(13, 112);
            this.TxtCaminhoArquivo.Name = "TxtCaminhoArquivo";
            this.TxtCaminhoArquivo.Size = new System.Drawing.Size(210, 20);
            this.TxtCaminhoArquivo.TabIndex = 1;
            // 
            // BtnProcurar
            // 
            this.BtnProcurar.Location = new System.Drawing.Point(229, 110);
            this.BtnProcurar.Name = "BtnProcurar";
            this.BtnProcurar.Size = new System.Drawing.Size(70, 23);
            this.BtnProcurar.TabIndex = 2;
            this.BtnProcurar.Text = "Procurar";
            this.BtnProcurar.UseVisualStyleBackColor = true;
            this.BtnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click);
            // 
            // BtnImportar
            // 
            this.BtnImportar.Location = new System.Drawing.Point(12, 148);
            this.BtnImportar.Name = "BtnImportar";
            this.BtnImportar.Size = new System.Drawing.Size(98, 36);
            this.BtnImportar.TabIndex = 3;
            this.BtnImportar.Text = "Importar";
            this.BtnImportar.UseVisualStyleBackColor = true;
            this.BtnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
            // 
            // LblLayoutImportacao
            // 
            this.LblLayoutImportacao.AutoSize = true;
            this.LblLayoutImportacao.Location = new System.Drawing.Point(192, 171);
            this.LblLayoutImportacao.Name = "LblLayoutImportacao";
            this.LblLayoutImportacao.Size = new System.Drawing.Size(109, 13);
            this.LblLayoutImportacao.TabIndex = 15;
            this.LblLayoutImportacao.TabStop = true;
            this.LblLayoutImportacao.Text = "Layout de importação";
            this.LblLayoutImportacao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblLayoutImportacao_LinkClicked);
            // 
            // FrmImportarPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 196);
            this.Controls.Add(this.LblLayoutImportacao);
            this.Controls.Add(this.BtnImportar);
            this.Controls.Add(this.BtnProcurar);
            this.Controls.Add(this.TxtCaminhoArquivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblCompetencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImportarPesquisa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Pesquisa";
            this.Load += new System.EventHandler(this.FrmImportarPesquisa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCompetencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCaminhoArquivo;
        private System.Windows.Forms.Button BtnProcurar;
        private System.Windows.Forms.Button BtnImportar;
        private System.Windows.Forms.LinkLabel LblLayoutImportacao;
    }
}