
namespace SCAC.Pages
{
    partial class pgHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MnsMenu = new System.Windows.Forms.MenuStrip();
            this.TsmReinvindicacao = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCriarRein = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiListarRein = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCriaEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiListarEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmOrgPubli = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCadOrg = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiListarOrg = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCadMora = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiListarMora = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmLider = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiListarLider = new System.Windows.Forms.ToolStripMenuItem();
            this.dASDSDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sDASDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dASDASDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aSDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnCriaRein = new System.Windows.Forms.Panel();
            this.Teste = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.MnsMenu.SuspendLayout();
            this.PnCriaRein.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MnsMenu);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 381);
            this.panel1.TabIndex = 1;
            // 
            // MnsMenu
            // 
            this.MnsMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.MnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmReinvindicacao,
            this.TsmEvento,
            this.TsmOrgPubli,
            this.TsmMorador,
            this.TsmLider});
            this.MnsMenu.Location = new System.Drawing.Point(0, 0);
            this.MnsMenu.Name = "MnsMenu";
            this.MnsMenu.Size = new System.Drawing.Size(138, 381);
            this.MnsMenu.TabIndex = 0;
            this.MnsMenu.Text = "menuStrip1";
            // 
            // TsmReinvindicacao
            // 
            this.TsmReinvindicacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiCriarRein,
            this.TsmiListarRein});
            this.TsmReinvindicacao.Name = "TsmReinvindicacao";
            this.TsmReinvindicacao.Size = new System.Drawing.Size(125, 19);
            this.TsmReinvindicacao.Text = "REIVINDICAÇÃO";
            // 
            // TsmiCriarRein
            // 
            this.TsmiCriarRein.Name = "TsmiCriarRein";
            this.TsmiCriarRein.Size = new System.Drawing.Size(183, 22);
            this.TsmiCriarRein.Text = "Criar Reivindicação";
            this.TsmiCriarRein.Click += new System.EventHandler(this.TsmiCriarRein_Click);
            // 
            // TsmiListarRein
            // 
            this.TsmiListarRein.Name = "TsmiListarRein";
            this.TsmiListarRein.Size = new System.Drawing.Size(183, 22);
            this.TsmiListarRein.Text = "Listar Reivindicações";
            // 
            // TsmEvento
            // 
            this.TsmEvento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiCriaEvento,
            this.TsmiListarEvento});
            this.TsmEvento.Name = "TsmEvento";
            this.TsmEvento.Size = new System.Drawing.Size(125, 19);
            this.TsmEvento.Text = "EVENTO";
            // 
            // TsmiCriaEvento
            // 
            this.TsmiCriaEvento.Name = "TsmiCriaEvento";
            this.TsmiCriaEvento.Size = new System.Drawing.Size(146, 22);
            this.TsmiCriaEvento.Text = "Criar Evento";
            // 
            // TsmiListarEvento
            // 
            this.TsmiListarEvento.Name = "TsmiListarEvento";
            this.TsmiListarEvento.Size = new System.Drawing.Size(146, 22);
            this.TsmiListarEvento.Text = "Listar Eventos";
            // 
            // TsmOrgPubli
            // 
            this.TsmOrgPubli.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiCadOrg,
            this.TsmiListarOrg});
            this.TsmOrgPubli.Name = "TsmOrgPubli";
            this.TsmOrgPubli.Size = new System.Drawing.Size(125, 19);
            this.TsmOrgPubli.Text = "ORGÃO PÚBLICO";
            // 
            // TsmiCadOrg
            // 
            this.TsmiCadOrg.Name = "TsmiCadOrg";
            this.TsmiCadOrg.Size = new System.Drawing.Size(160, 22);
            this.TsmiCadOrg.Text = "Cadastrar Orgão";
            // 
            // TsmiListarOrg
            // 
            this.TsmiListarOrg.Name = "TsmiListarOrg";
            this.TsmiListarOrg.Size = new System.Drawing.Size(160, 22);
            this.TsmiListarOrg.Text = "Listar Orgãos";
            // 
            // TsmMorador
            // 
            this.TsmMorador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiCadMora,
            this.TsmiListarMora});
            this.TsmMorador.Name = "TsmMorador";
            this.TsmMorador.Size = new System.Drawing.Size(125, 19);
            this.TsmMorador.Text = "MORADOR";
            // 
            // TsmiCadMora
            // 
            this.TsmiCadMora.Name = "TsmiCadMora";
            this.TsmiCadMora.Size = new System.Drawing.Size(186, 22);
            this.TsmiCadMora.Text = "Cadastro de Morador";
            // 
            // TsmiListarMora
            // 
            this.TsmiListarMora.Name = "TsmiListarMora";
            this.TsmiListarMora.Size = new System.Drawing.Size(186, 22);
            this.TsmiListarMora.Text = "Listar Moradores";
            // 
            // TsmLider
            // 
            this.TsmLider.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiListarLider});
            this.TsmLider.Name = "TsmLider";
            this.TsmLider.Size = new System.Drawing.Size(125, 19);
            this.TsmLider.Text = "LÍDER COMUNITARIO";
            // 
            // TsmiListarLider
            // 
            this.TsmiListarLider.Name = "TsmiListarLider";
            this.TsmiListarLider.Size = new System.Drawing.Size(142, 22);
            this.TsmiListarLider.Text = "Listar Líderes";
            // 
            // dASDSDAToolStripMenuItem
            // 
            this.dASDSDAToolStripMenuItem.Name = "dASDSDAToolStripMenuItem";
            this.dASDSDAToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.dASDSDAToolStripMenuItem.Text = "DASDSDA";
            // 
            // sDASDASToolStripMenuItem
            // 
            this.sDASDASToolStripMenuItem.Name = "sDASDASToolStripMenuItem";
            this.sDASDASToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sDASDASToolStripMenuItem.Text = "SDASDAS";
            // 
            // dASDASDToolStripMenuItem1
            // 
            this.dASDASDToolStripMenuItem1.Name = "dASDASDToolStripMenuItem1";
            this.dASDASDToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.dASDASDToolStripMenuItem1.Text = "DASDASD";
            // 
            // aSDAToolStripMenuItem
            // 
            this.aSDAToolStripMenuItem.Name = "aSDAToolStripMenuItem";
            this.aSDAToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aSDAToolStripMenuItem.Text = "ASDA";
            // 
            // aSDToolStripMenuItem
            // 
            this.aSDToolStripMenuItem.Name = "aSDToolStripMenuItem";
            this.aSDToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.aSDToolStripMenuItem.Text = "ASD";
            // 
            // PnCriaRein
            // 
            this.PnCriaRein.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnCriaRein.BackColor = System.Drawing.Color.Transparent;
            this.PnCriaRein.Controls.Add(this.Teste);
            this.PnCriaRein.Location = new System.Drawing.Point(158, 57);
            this.PnCriaRein.Name = "PnCriaRein";
            this.PnCriaRein.Size = new System.Drawing.Size(653, 381);
            this.PnCriaRein.TabIndex = 3;
            this.PnCriaRein.Visible = false;
            // 
            // Teste
            // 
            this.Teste.AutoSize = true;
            this.Teste.Location = new System.Drawing.Point(600, 19);
            this.Teste.Name = "Teste";
            this.Teste.Size = new System.Drawing.Size(30, 13);
            this.Teste.TabIndex = 0;
            this.Teste.Text = "teste";
            // 
            // lblHome
            // 
            this.lblHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(-3, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(810, 18);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "SCAC - SISTEMA DE CONTROLE DE AÇÕES COMUNITÁRIAS";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pgHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCAC.Properties.Resources.LogoSample;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.PnCriaRein);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "pgHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCAC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.pgHome_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MnsMenu.ResumeLayout(false);
            this.MnsMenu.PerformLayout();
            this.PnCriaRein.ResumeLayout(false);
            this.PnCriaRein.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem dASDSDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sDASDASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dASDASDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aSDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSDToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MnsMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmReinvindicacao;
        private System.Windows.Forms.ToolStripMenuItem TsmiCriarRein;
        private System.Windows.Forms.ToolStripMenuItem TsmiListarRein;
        private System.Windows.Forms.ToolStripMenuItem TsmEvento;
        private System.Windows.Forms.ToolStripMenuItem TsmiCriaEvento;
        private System.Windows.Forms.ToolStripMenuItem TsmiListarEvento;
        private System.Windows.Forms.ToolStripMenuItem TsmOrgPubli;
        private System.Windows.Forms.ToolStripMenuItem TsmiCadOrg;
        private System.Windows.Forms.ToolStripMenuItem TsmiListarOrg;
        private System.Windows.Forms.ToolStripMenuItem TsmMorador;
        private System.Windows.Forms.ToolStripMenuItem TsmiCadMora;
        private System.Windows.Forms.ToolStripMenuItem TsmiListarMora;
        private System.Windows.Forms.ToolStripMenuItem TsmLider;
        private System.Windows.Forms.ToolStripMenuItem TsmiListarLider;
        private System.Windows.Forms.Panel PnCriaRein;
        private System.Windows.Forms.Label Teste;
        private System.Windows.Forms.Label lblHome;
    }
}