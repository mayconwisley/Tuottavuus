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
            this.SuspendLayout();
            // 
            // PbBarraCarregamento
            // 
            this.PbBarraCarregamento.Location = new System.Drawing.Point(12, 26);
            this.PbBarraCarregamento.Name = "PbBarraCarregamento";
            this.PbBarraCarregamento.Size = new System.Drawing.Size(473, 23);
            this.PbBarraCarregamento.TabIndex = 0;
            // 
            // FrmBarraCarregamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 75);
            this.Controls.Add(this.PbBarraCarregamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBarraCarregamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barra Carregamento";
            this.Activated += new System.EventHandler(this.FrmBarraCarregamento_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar PbBarraCarregamento;
    }
}