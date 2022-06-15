namespace Tuottavuus
{
    partial class FrmCadastroMetaPeso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CbxIndicador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMeta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.DgvMetaPeso = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Indicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblInfoMetaPeso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMetaPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxIndicador
            // 
            this.CbxIndicador.DisplayMember = "Descricao";
            this.CbxIndicador.FormattingEnabled = true;
            this.CbxIndicador.Location = new System.Drawing.Point(12, 29);
            this.CbxIndicador.Name = "CbxIndicador";
            this.CbxIndicador.Size = new System.Drawing.Size(193, 21);
            this.CbxIndicador.TabIndex = 0;
            this.CbxIndicador.ValueMember = "Id";
            this.CbxIndicador.SelectedIndexChanged += new System.EventHandler(this.CbxIndicador_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indicador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Meta";
            // 
            // TxtMeta
            // 
            this.TxtMeta.Location = new System.Drawing.Point(12, 82);
            this.TxtMeta.Name = "TxtMeta";
            this.TxtMeta.Size = new System.Drawing.Size(63, 20);
            this.TxtMeta.TabIndex = 1;
            this.TxtMeta.Text = "0,00";
            this.TxtMeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMeta.TextChanged += new System.EventHandler(this.TxtMeta_TextChanged);
            this.TxtMeta.Enter += new System.EventHandler(this.TxtMeta_Enter);
            this.TxtMeta.Leave += new System.EventHandler(this.TxtMeta_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso";
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(142, 82);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(63, 20);
            this.TxtPeso.TabIndex = 2;
            this.TxtPeso.Text = "0,00";
            this.TxtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPeso.TextChanged += new System.EventHandler(this.TxtPeso_TextChanged);
            this.TxtPeso.Enter += new System.EventHandler(this.TxtPeso_Enter);
            this.TxtPeso.Leave += new System.EventHandler(this.TxtPeso_Leave);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(224, 16);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 3;
            this.BtnGravar.Text = "&Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(224, 45);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 4;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(224, 74);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 5;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // DgvMetaPeso
            // 
            this.DgvMetaPeso.AllowUserToAddRows = false;
            this.DgvMetaPeso.AllowUserToDeleteRows = false;
            this.DgvMetaPeso.AllowUserToOrderColumns = true;
            this.DgvMetaPeso.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvMetaPeso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvMetaPeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMetaPeso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descricao,
            this.Id_Indicador,
            this.Meta,
            this.Peso});
            this.DgvMetaPeso.Location = new System.Drawing.Point(12, 146);
            this.DgvMetaPeso.MultiSelect = false;
            this.DgvMetaPeso.Name = "DgvMetaPeso";
            this.DgvMetaPeso.ReadOnly = true;
            this.DgvMetaPeso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMetaPeso.Size = new System.Drawing.Size(287, 130);
            this.DgvMetaPeso.TabIndex = 6;
            this.DgvMetaPeso.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMetaPeso_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 80;
            // 
            // Id_Indicador
            // 
            this.Id_Indicador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id_Indicador.DataPropertyName = "Id_Indicador";
            this.Id_Indicador.HeaderText = "Id_Indicador";
            this.Id_Indicador.Name = "Id_Indicador";
            this.Id_Indicador.ReadOnly = true;
            this.Id_Indicador.Visible = false;
            // 
            // Meta
            // 
            this.Meta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Meta.DataPropertyName = "Meta";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Meta.DefaultCellStyle = dataGridViewCellStyle1;
            this.Meta.HeaderText = "Meta";
            this.Meta.Name = "Meta";
            this.Meta.ReadOnly = true;
            this.Meta.Width = 56;
            // 
            // Peso
            // 
            this.Peso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Peso.DataPropertyName = "Peso";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Peso.DefaultCellStyle = dataGridViewCellStyle2;
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.Width = 56;
            // 
            // LblInfoMetaPeso
            // 
            this.LblInfoMetaPeso.AutoSize = true;
            this.LblInfoMetaPeso.Location = new System.Drawing.Point(12, 130);
            this.LblInfoMetaPeso.Name = "LblInfoMetaPeso";
            this.LblInfoMetaPeso.Size = new System.Drawing.Size(81, 13);
            this.LblInfoMetaPeso.TabIndex = 6;
            this.LblInfoMetaPeso.Text = "Meta/Peso - 00";
            // 
            // FrmCadastroMetaPeso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 289);
            this.Controls.Add(this.LblInfoMetaPeso);
            this.Controls.Add(this.DgvMetaPeso);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxIndicador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroMetaPeso";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Meta Peso";
            this.Load += new System.EventHandler(this.FrmCadastroMetaPeso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMetaPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxIndicador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridView DgvMetaPeso;
        private System.Windows.Forms.Label LblInfoMetaPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Indicador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
    }
}