namespace GeradorDeTestesWinApp
{
    partial class TelaPrincipalForm
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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            disciplinasToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            questõesToolStripMenuItem = new ToolStripMenuItem();
            testesToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnDuplicarTeste = new ToolStripButton();
            btnVisualizarDetalhes = new ToolStripButton();
            btnGerarGabarito = new ToolStripButton();
            btnGerarPdf = new ToolStripButton();
            lblTipoCadastro = new ToolStripLabel();
            pnlRegistros = new Panel();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1029, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinasToolStripMenuItem, materiasToolStripMenuItem, questõesToolStripMenuItem, testesToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(91, 25);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // disciplinasToolStripMenuItem
            // 
            disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            disciplinasToolStripMenuItem.Size = new Size(154, 26);
            disciplinasToolStripMenuItem.Text = "Disciplinas";
            disciplinasToolStripMenuItem.Click += disciplinasToolStripMenuItem_Click;
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(154, 26);
            materiasToolStripMenuItem.Text = "Matérias";
            materiasToolStripMenuItem.Click += materiasToolStripMenuItem_Click;
            // 
            // questõesToolStripMenuItem
            // 
            questõesToolStripMenuItem.Name = "questõesToolStripMenuItem";
            questõesToolStripMenuItem.Size = new Size(154, 26);
            questõesToolStripMenuItem.Text = "Questões";
            questõesToolStripMenuItem.Click += questoesToolStripMenuItem_Click;
            // 
            // testesToolStripMenuItem
            // 
            testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            testesToolStripMenuItem.Size = new Size(154, 26);
            testesToolStripMenuItem.Text = "Testes";
            testesToolStripMenuItem.Click += testesToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator3, btnDuplicarTeste, btnVisualizarDetalhes, btnGerarPdf, btnGerarGabarito, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 31);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1029, 41);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackgroundImageLayout = ImageLayout.None;
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(38, 38);
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImageLayout = ImageLayout.None;
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(38, 38);
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackgroundImageLayout = ImageLayout.None;
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources.btnExcluir;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(38, 38);
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 41);
            // 
            // btnDuplicarTeste
            // 
            btnDuplicarTeste.BackgroundImageLayout = ImageLayout.None;
            btnDuplicarTeste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDuplicarTeste.Enabled = false;
            btnDuplicarTeste.Image = Properties.Resources.btnDuplicarTeste;
            btnDuplicarTeste.ImageScaling = ToolStripItemImageScaling.None;
            btnDuplicarTeste.ImageTransparentColor = Color.Magenta;
            btnDuplicarTeste.Name = "btnDuplicarTeste";
            btnDuplicarTeste.Padding = new Padding(5);
            btnDuplicarTeste.Size = new Size(38, 38);
            btnDuplicarTeste.Click += btnDuplicarTeste_Click;
            // 
            // btnVisualizarDetalhes
            // 
            btnVisualizarDetalhes.BackgroundImageLayout = ImageLayout.None;
            btnVisualizarDetalhes.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizarDetalhes.Enabled = false;
            btnVisualizarDetalhes.Image = Properties.Resources.btnVisualizarDetalhes;
            btnVisualizarDetalhes.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizarDetalhes.ImageTransparentColor = Color.Magenta;
            btnVisualizarDetalhes.Name = "btnVisualizarDetalhes";
            btnVisualizarDetalhes.Padding = new Padding(5);
            btnVisualizarDetalhes.Size = new Size(38, 38);
            btnVisualizarDetalhes.Click += btnVisualizarDetalhes_Click;
            // 
            // btnGerarGabarito
            // 
            btnGerarGabarito.BackgroundImageLayout = ImageLayout.None;
            btnGerarGabarito.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGerarGabarito.Enabled = false;
            btnGerarGabarito.Image = Properties.Resources.btnGerarGabarito;
            btnGerarGabarito.ImageScaling = ToolStripItemImageScaling.None;
            btnGerarGabarito.ImageTransparentColor = Color.Magenta;
            btnGerarGabarito.Name = "btnGerarGabarito";
            btnGerarGabarito.Padding = new Padding(5);
            btnGerarGabarito.Size = new Size(38, 38);
            btnGerarGabarito.Click += btnGerarGabarito_Click;
            // 
            // btnGerarPdf
            // 
            btnGerarPdf.BackgroundImageLayout = ImageLayout.None;
            btnGerarPdf.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGerarPdf.Enabled = false;
            btnGerarPdf.Image = Properties.Resources.btnGerarPdf;
            btnGerarPdf.ImageScaling = ToolStripItemImageScaling.None;
            btnGerarPdf.ImageTransparentColor = Color.Magenta;
            btnGerarPdf.Name = "btnGerarPdf";
            btnGerarPdf.Padding = new Padding(5);
            btnGerarPdf.Size = new Size(38, 38);
            btnGerarPdf.Click += btnGerarPdf_Click;
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(127, 38);
            lblTipoCadastro.Text = "Tipo de Cadastro";
            // 
            // pnlRegistros
            // 
            pnlRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRegistros.Location = new Point(0, 75);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(1029, 526);
            pnlRegistros.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 604);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1029, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(195, 21);
            statusLabelPrincipal.Text = "Visualizando 0 registro(s)...";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(statusStrip1);
            Controls.Add(pnlRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de Testes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem disciplinasToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel lblTipoCadastro;
        private Panel pnlRegistros;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem questõesToolStripMenuItem;
        private ToolStripMenuItem testesToolStripMenuItem;
        private ToolStripButton btnDuplicarTeste;
        private ToolStripButton btnVisualizarDetalhes;
        private ToolStripButton btnGerarPdf;
        private ToolStripButton btnGerarGabarito;
    }
}