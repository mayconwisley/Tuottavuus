﻿namespace Tuottavuus
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCadastroEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCadastroDepartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCadastroCompetencia = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCadastroEmpregado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SubMenuCadastroIndicador = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCadastroAtividade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SubMenuCadastroFeriado = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCadastroValorBaseProdutividade = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCadastroMetaPeso = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAvaliacao = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuAvaliacaoAvaliar = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuAvaliacaoConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuAvaliacaoConsultaAtividade = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutividade = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuProdutividadeCalcular = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuProdutividadeConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuChamados = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuChamadosImportar = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuChamadosCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuChamadosConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPesquisa = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuPesquisaImportar = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuPesquisaCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuPesquisaConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuRelatoriosRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusPrincipal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuPrincipal.SuspendLayout();
            this.StatusPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuAvaliacao,
            this.MenuProdutividade,
            this.MenuChamados,
            this.MenuPesquisa,
            this.MenuRelatorio,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(1008, 24);
            this.MenuPrincipal.TabIndex = 1;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuCadastroEmpresa,
            this.SubMenuCadastroDepartamento,
            this.SubMenuCadastroCompetencia,
            this.SubMenuCadastroEmpregado,
            this.toolStripSeparator1,
            this.SubMenuCadastroIndicador,
            this.SubMenuCadastroAtividade,
            this.toolStripSeparator2,
            this.SubMenuCadastroFeriado,
            this.SubMenuCadastroValorBaseProdutividade,
            this.SubMenuCadastroMetaPeso});
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(66, 20);
            this.MenuCadastro.Text = "Cadastro";
            // 
            // SubMenuCadastroEmpresa
            // 
            this.SubMenuCadastroEmpresa.Name = "SubMenuCadastroEmpresa";
            this.SubMenuCadastroEmpresa.Size = new System.Drawing.Size(204, 22);
            this.SubMenuCadastroEmpresa.Text = "Empresa";
            this.SubMenuCadastroEmpresa.Click += new System.EventHandler(this.SubMenuCadastroEmpresa_Click);
            // 
            // SubMenuCadastroDepartamento
            // 
            this.SubMenuCadastroDepartamento.Name = "SubMenuCadastroDepartamento";
            this.SubMenuCadastroDepartamento.Size = new System.Drawing.Size(204, 22);
            this.SubMenuCadastroDepartamento.Text = "Departamento";
            this.SubMenuCadastroDepartamento.Click += new System.EventHandler(this.SubMenuCadastroDepartamento_Click);
            // 
            // SubMenuCadastroCompetencia
            // 
            this.SubMenuCadastroCompetencia.Name = "SubMenuCadastroCompetencia";
            this.SubMenuCadastroCompetencia.Size = new System.Drawing.Size(204, 22);
            this.SubMenuCadastroCompetencia.Text = "Competência";
            this.SubMenuCadastroCompetencia.Click += new System.EventHandler(this.SubMenuCadastroCompetencia_Click);
            // 
            // SubMenuCadastroEmpregado
            // 
            this.SubMenuCadastroEmpregado.Name = "SubMenuCadastroEmpregado";
            this.SubMenuCadastroEmpregado.Size = new System.Drawing.Size(204, 22);
            this.SubMenuCadastroEmpregado.Text = "Empregado";
            this.SubMenuCadastroEmpregado.Click += new System.EventHandler(this.SubMenuCadastroEmpregado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // SubMenuCadastroIndicador
            // 
            this.SubMenuCadastroIndicador.Name = "SubMenuCadastroIndicador";
            this.SubMenuCadastroIndicador.Size = new System.Drawing.Size(204, 22);
            this.SubMenuCadastroIndicador.Text = "Indicadores";
            this.SubMenuCadastroIndicador.Click += new System.EventHandler(this.SubMenuCadastroIndicador_Click);
            // 
            // SubMenuCadastroAtividade
            // 
            this.SubMenuCadastroAtividade.Name = "SubMenuCadastroAtividade";
            this.SubMenuCadastroAtividade.Size = new System.Drawing.Size(204, 22);
            this.SubMenuCadastroAtividade.Text = "Atividades";
            this.SubMenuCadastroAtividade.Click += new System.EventHandler(this.SubMenuCadastroAtividade_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // SubMenuCadastroFeriado
            // 
            this.SubMenuCadastroFeriado.Name = "SubMenuCadastroFeriado";
            this.SubMenuCadastroFeriado.Size = new System.Drawing.Size(204, 22);
            this.SubMenuCadastroFeriado.Text = "Feriados";
            this.SubMenuCadastroFeriado.Click += new System.EventHandler(this.SubMenuCadastroFeriado_Click);
            // 
            // SubMenuCadastroValorBaseProdutividade
            // 
            this.SubMenuCadastroValorBaseProdutividade.Name = "SubMenuCadastroValorBaseProdutividade";
            this.SubMenuCadastroValorBaseProdutividade.Size = new System.Drawing.Size(204, 22);
            this.SubMenuCadastroValorBaseProdutividade.Text = "Valor Base Produtividade";
            this.SubMenuCadastroValorBaseProdutividade.Click += new System.EventHandler(this.SubMenuCadastroValorBaseProdutividade_Click);
            // 
            // SubMenuCadastroMetaPeso
            // 
            this.SubMenuCadastroMetaPeso.Name = "SubMenuCadastroMetaPeso";
            this.SubMenuCadastroMetaPeso.Size = new System.Drawing.Size(204, 22);
            this.SubMenuCadastroMetaPeso.Text = "Valor Meta/Peso";
            this.SubMenuCadastroMetaPeso.Click += new System.EventHandler(this.SubMenuCadastroMetaPeso_Click);
            // 
            // MenuAvaliacao
            // 
            this.MenuAvaliacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuAvaliacaoAvaliar,
            this.SubMenuAvaliacaoConsultar,
            this.SubMenuAvaliacaoConsultaAtividade});
            this.MenuAvaliacao.Name = "MenuAvaliacao";
            this.MenuAvaliacao.Size = new System.Drawing.Size(70, 20);
            this.MenuAvaliacao.Text = "Avaliação";
            // 
            // SubMenuAvaliacaoAvaliar
            // 
            this.SubMenuAvaliacaoAvaliar.Name = "SubMenuAvaliacaoAvaliar";
            this.SubMenuAvaliacaoAvaliar.Size = new System.Drawing.Size(174, 22);
            this.SubMenuAvaliacaoAvaliar.Text = "Avaliar";
            this.SubMenuAvaliacaoAvaliar.Click += new System.EventHandler(this.SubMenuAvaliacaoAvaliar_Click);
            // 
            // SubMenuAvaliacaoConsultar
            // 
            this.SubMenuAvaliacaoConsultar.Name = "SubMenuAvaliacaoConsultar";
            this.SubMenuAvaliacaoConsultar.Size = new System.Drawing.Size(174, 22);
            this.SubMenuAvaliacaoConsultar.Text = "Consultar";
            this.SubMenuAvaliacaoConsultar.Click += new System.EventHandler(this.SubMenuAvaliacaoConsultar_Click);
            // 
            // SubMenuAvaliacaoConsultaAtividade
            // 
            this.SubMenuAvaliacaoConsultaAtividade.Name = "SubMenuAvaliacaoConsultaAtividade";
            this.SubMenuAvaliacaoConsultaAtividade.Size = new System.Drawing.Size(174, 22);
            this.SubMenuAvaliacaoConsultaAtividade.Text = "Consulta Atividade";
            this.SubMenuAvaliacaoConsultaAtividade.Click += new System.EventHandler(this.SubMenuAvaliacaoConsultaAtividade_Click);
            // 
            // MenuProdutividade
            // 
            this.MenuProdutividade.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuProdutividadeCalcular,
            this.SubMenuProdutividadeConsultar});
            this.MenuProdutividade.Name = "MenuProdutividade";
            this.MenuProdutividade.Size = new System.Drawing.Size(93, 20);
            this.MenuProdutividade.Text = "Produtividade";
            // 
            // SubMenuProdutividadeCalcular
            // 
            this.SubMenuProdutividadeCalcular.Name = "SubMenuProdutividadeCalcular";
            this.SubMenuProdutividadeCalcular.Size = new System.Drawing.Size(125, 22);
            this.SubMenuProdutividadeCalcular.Text = "Calcular";
            this.SubMenuProdutividadeCalcular.Click += new System.EventHandler(this.SubMenuProdutividadeCalcular_Click);
            // 
            // SubMenuProdutividadeConsultar
            // 
            this.SubMenuProdutividadeConsultar.Name = "SubMenuProdutividadeConsultar";
            this.SubMenuProdutividadeConsultar.Size = new System.Drawing.Size(125, 22);
            this.SubMenuProdutividadeConsultar.Text = "Consultar";
            this.SubMenuProdutividadeConsultar.Click += new System.EventHandler(this.SubMenuProdutividadeConsultar_Click);
            // 
            // MenuChamados
            // 
            this.MenuChamados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuChamadosImportar,
            this.SubMenuChamadosCadastrar,
            this.SubMenuChamadosConsultar});
            this.MenuChamados.Name = "MenuChamados";
            this.MenuChamados.Size = new System.Drawing.Size(76, 20);
            this.MenuChamados.Text = "Chamados";
            // 
            // SubMenuChamadosImportar
            // 
            this.SubMenuChamadosImportar.Name = "SubMenuChamadosImportar";
            this.SubMenuChamadosImportar.Size = new System.Drawing.Size(180, 22);
            this.SubMenuChamadosImportar.Text = "Importar";
            this.SubMenuChamadosImportar.Click += new System.EventHandler(this.SubMenuChamadosImportar_Click);
            // 
            // SubMenuChamadosCadastrar
            // 
            this.SubMenuChamadosCadastrar.Name = "SubMenuChamadosCadastrar";
            this.SubMenuChamadosCadastrar.Size = new System.Drawing.Size(180, 22);
            this.SubMenuChamadosCadastrar.Text = "Cadastrar";
            this.SubMenuChamadosCadastrar.Click += new System.EventHandler(this.SubMenuChamadosCadastrar_Click);
            // 
            // SubMenuChamadosConsultar
            // 
            this.SubMenuChamadosConsultar.Name = "SubMenuChamadosConsultar";
            this.SubMenuChamadosConsultar.Size = new System.Drawing.Size(180, 22);
            this.SubMenuChamadosConsultar.Text = "Consultar";
            // 
            // MenuPesquisa
            // 
            this.MenuPesquisa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuPesquisaImportar,
            this.SubMenuPesquisaCadastrar,
            this.SubMenuPesquisaConsultar});
            this.MenuPesquisa.Name = "MenuPesquisa";
            this.MenuPesquisa.Size = new System.Drawing.Size(65, 20);
            this.MenuPesquisa.Text = "Pesquisa";
            // 
            // SubMenuPesquisaImportar
            // 
            this.SubMenuPesquisaImportar.Name = "SubMenuPesquisaImportar";
            this.SubMenuPesquisaImportar.Size = new System.Drawing.Size(125, 22);
            this.SubMenuPesquisaImportar.Text = "Importar";
            this.SubMenuPesquisaImportar.Click += new System.EventHandler(this.SubMenuPesquisaImportar_Click);
            // 
            // SubMenuPesquisaCadastrar
            // 
            this.SubMenuPesquisaCadastrar.Name = "SubMenuPesquisaCadastrar";
            this.SubMenuPesquisaCadastrar.Size = new System.Drawing.Size(125, 22);
            this.SubMenuPesquisaCadastrar.Text = "Cadastrar";
            this.SubMenuPesquisaCadastrar.Click += new System.EventHandler(this.SubMenuPesquisaCadastrar_Click);
            // 
            // SubMenuPesquisaConsultar
            // 
            this.SubMenuPesquisaConsultar.Name = "SubMenuPesquisaConsultar";
            this.SubMenuPesquisaConsultar.Size = new System.Drawing.Size(125, 22);
            this.SubMenuPesquisaConsultar.Text = "Consultar";
            this.SubMenuPesquisaConsultar.Click += new System.EventHandler(this.SubMenuPesquisaConsultar_Click);
            // 
            // MenuRelatorio
            // 
            this.MenuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRelatoriosRelatorio});
            this.MenuRelatorio.Name = "MenuRelatorio";
            this.MenuRelatorio.Size = new System.Drawing.Size(71, 20);
            this.MenuRelatorio.Text = "Relatórios";
            // 
            // SubMenuRelatoriosRelatorio
            // 
            this.SubMenuRelatoriosRelatorio.Name = "SubMenuRelatoriosRelatorio";
            this.SubMenuRelatoriosRelatorio.Size = new System.Drawing.Size(121, 22);
            this.SubMenuRelatoriosRelatorio.Text = "Relatório";
            this.SubMenuRelatoriosRelatorio.Click += new System.EventHandler(this.SubMenuRelatoriosRelatorio_Click);
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // StatusPrincipal
            // 
            this.StatusPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.StatusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.StatusPrincipal.Location = new System.Drawing.Point(0, 659);
            this.StatusPrincipal.Name = "StatusPrincipal";
            this.StatusPrincipal.Size = new System.Drawing.Size(1008, 22);
            this.StatusPrincipal.TabIndex = 2;
            this.StatusPrincipal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(217, 17);
            this.toolStripStatusLabel1.Text = "Desenvolvido por: Maycon Wisley - v1.0";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tuottavuus.Properties.Resources.Tuattavuus;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.StatusPrincipal);
            this.Controls.Add(this.MenuPrincipal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tuottavuus";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.StatusPrincipal.ResumeLayout(false);
            this.StatusPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.StatusStrip StatusPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastroEmpresa;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastroEmpregado;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastroAtividade;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastroCompetencia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastroFeriado;
        private System.Windows.Forms.ToolStripMenuItem MenuAvaliacao;
        private System.Windows.Forms.ToolStripMenuItem SubMenuAvaliacaoAvaliar;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutividade;
        private System.Windows.Forms.ToolStripMenuItem SubMenuProdutividadeCalcular;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastroValorBaseProdutividade;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastroDepartamento;
        private System.Windows.Forms.ToolStripMenuItem SubMenuRelatoriosRelatorio;
        private System.Windows.Forms.ToolStripMenuItem SubMenuAvaliacaoConsultar;
        private System.Windows.Forms.ToolStripMenuItem SubMenuProdutividadeConsultar;
        private System.Windows.Forms.ToolStripMenuItem SubMenuAvaliacaoConsultaAtividade;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastroIndicador;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastroMetaPeso;
        private System.Windows.Forms.ToolStripMenuItem MenuPesquisa;
        private System.Windows.Forms.ToolStripMenuItem SubMenuPesquisaImportar;
        private System.Windows.Forms.ToolStripMenuItem SubMenuPesquisaCadastrar;
        private System.Windows.Forms.ToolStripMenuItem SubMenuPesquisaConsultar;
        private System.Windows.Forms.ToolStripMenuItem MenuChamados;
        private System.Windows.Forms.ToolStripMenuItem SubMenuChamadosImportar;
        private System.Windows.Forms.ToolStripMenuItem SubMenuChamadosCadastrar;
        private System.Windows.Forms.ToolStripMenuItem SubMenuChamadosConsultar;
    }
}

