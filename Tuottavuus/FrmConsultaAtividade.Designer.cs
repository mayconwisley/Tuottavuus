namespace Tuottavuus
{
    partial class FrmConsultaAtividade
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbDepartamento = new System.Windows.Forms.RadioButton();
            this.RbEmpregado = new System.Windows.Forms.RadioButton();
            this.RbEmpresa = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CbxDepartamento = new System.Windows.Forms.ComboBox();
            this.CbxEmpregado = new System.Windows.Forms.ComboBox();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 19);
            this.maskedTextBox1.Mask = "00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(94, 19);
            this.maskedTextBox2.Mask = "00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RbDepartamento);
            this.groupBox2.Controls.Add(this.RbEmpregado);
            this.groupBox2.Controls.Add(this.RbEmpresa);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // RbDepartamento
            // 
            this.RbDepartamento.AutoSize = true;
            this.RbDepartamento.Location = new System.Drawing.Point(163, 19);
            this.RbDepartamento.Name = "RbDepartamento";
            this.RbDepartamento.Size = new System.Drawing.Size(92, 17);
            this.RbDepartamento.TabIndex = 4;
            this.RbDepartamento.Text = "Departamento";
            this.RbDepartamento.UseVisualStyleBackColor = true;
            // 
            // RbEmpregado
            // 
            this.RbEmpregado.AutoSize = true;
            this.RbEmpregado.Location = new System.Drawing.Point(78, 19);
            this.RbEmpregado.Name = "RbEmpregado";
            this.RbEmpregado.Size = new System.Drawing.Size(79, 17);
            this.RbEmpregado.TabIndex = 5;
            this.RbEmpregado.Text = "Empregado";
            this.RbEmpregado.UseVisualStyleBackColor = true;
            // 
            // RbEmpresa
            // 
            this.RbEmpresa.AutoSize = true;
            this.RbEmpresa.Checked = true;
            this.RbEmpresa.Location = new System.Drawing.Point(6, 19);
            this.RbEmpresa.Name = "RbEmpresa";
            this.RbEmpresa.Size = new System.Drawing.Size(66, 17);
            this.RbEmpresa.TabIndex = 6;
            this.RbEmpresa.TabStop = true;
            this.RbEmpresa.Text = "Empresa";
            this.RbEmpresa.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CbxDepartamento);
            this.groupBox3.Controls.Add(this.CbxEmpregado);
            this.groupBox3.Controls.Add(this.CbxEmpresa);
            this.groupBox3.Location = new System.Drawing.Point(282, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 136);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // CbxDepartamento
            // 
            this.CbxDepartamento.DisplayMember = "Descricao";
            this.CbxDepartamento.Enabled = false;
            this.CbxDepartamento.FormattingEnabled = true;
            this.CbxDepartamento.IntegralHeight = false;
            this.CbxDepartamento.Location = new System.Drawing.Point(6, 99);
            this.CbxDepartamento.Name = "CbxDepartamento";
            this.CbxDepartamento.Size = new System.Drawing.Size(310, 21);
            this.CbxDepartamento.TabIndex = 13;
            this.CbxDepartamento.ValueMember = "Descricao";
            // 
            // CbxEmpregado
            // 
            this.CbxEmpregado.DisplayMember = "Nome";
            this.CbxEmpregado.Enabled = false;
            this.CbxEmpregado.FormattingEnabled = true;
            this.CbxEmpregado.IntegralHeight = false;
            this.CbxEmpregado.Location = new System.Drawing.Point(6, 59);
            this.CbxEmpregado.Name = "CbxEmpregado";
            this.CbxEmpregado.Size = new System.Drawing.Size(310, 21);
            this.CbxEmpregado.TabIndex = 12;
            this.CbxEmpregado.ValueMember = "Nome";
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.IntegralHeight = false;
            this.CbxEmpresa.Location = new System.Drawing.Point(6, 19);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(310, 21);
            this.CbxEmpresa.TabIndex = 11;
            this.CbxEmpresa.ValueMember = "Nome";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(862, 252);
            this.dataGridView1.TabIndex = 3;
            // 
            // FrmConsultaAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaAtividade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Atividade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RbDepartamento;
        private System.Windows.Forms.RadioButton RbEmpregado;
        private System.Windows.Forms.RadioButton RbEmpresa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CbxDepartamento;
        private System.Windows.Forms.ComboBox CbxEmpregado;
        private System.Windows.Forms.ComboBox CbxEmpresa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}