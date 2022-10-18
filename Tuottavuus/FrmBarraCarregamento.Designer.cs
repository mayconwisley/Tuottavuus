namespace Tuottavuus
{
    partial class FrmBarraCarregamento
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
            this.PbBarraCarregamento = new System.Windows.Forms.ProgressBar();
            this.LblRegistro = new System.Windows.Forms.Label();
            this.LblPorcentagem = new System.Windows.Forms.Label();
            this.BWProcessamento = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // PbBarraCarregamento
            // 
            this.PbBarraCarregamento.Location = new System.Drawing.Point(12, 28);
            this.PbBarraCarregamento.Name = "PbBarraCarregamento";
            this.PbBarraCarregamento.Size = new System.Drawing.Size(473, 23);
            this.PbBarraCarregamento.TabIndex = 0;
            // 
            // LblRegistro
            // 
            this.LblRegistro.AutoSize = true;
            this.LblRegistro.Location = new System.Drawing.Point(12, 54);
            this.LblRegistro.Name = "LblRegistro";
            this.LblRegistro.Size = new System.Drawing.Size(162, 13);
            this.LblRegistro.TabIndex = 1;
            this.LblRegistro.Text = "Processando linha 00 do arquivo";
            // 
            // LblPorcentagem
            // 
            this.LblPorcentagem.Location = new System.Drawing.Point(450, 53);
            this.LblPorcentagem.Name = "LblPorcentagem";
            this.LblPorcentagem.Size = new System.Drawing.Size(35, 14);
            this.LblPorcentagem.TabIndex = 2;
            this.LblPorcentagem.Text = "000%";
            // 
            // BWProcessamento
            // 
            this.BWProcessamento.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWProcessamento_DoWork);
            this.BWProcessamento.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWProcessamento_ProgressChanged);
            // 
            // FrmBarraCarregamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 85);
            this.Controls.Add(this.LblPorcentagem);
            this.Controls.Add(this.LblRegistro);
            this.Controls.Add(this.PbBarraCarregamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBarraCarregamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barra Carregamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PbBarraCarregamento;
        private System.Windows.Forms.Label LblRegistro;
        private System.Windows.Forms.Label LblPorcentagem;
        private System.ComponentModel.BackgroundWorker BWProcessamento;
    }
}