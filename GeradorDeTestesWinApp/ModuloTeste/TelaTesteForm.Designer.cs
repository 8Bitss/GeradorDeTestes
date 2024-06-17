namespace GeradorDeTestesWinApp.ModuloTeste
{
    partial class TelaTesteForm
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
            lbl = new Label();
            txtTitulo = new TextBox();
            cmbDisciplinas = new ComboBox();
            lblDisciplina = new Label();
            cmbMaterias = new ComboBox();
            lblMaterias = new Label();
            label1 = new Label();
            txtQtdQuestoes = new NumericUpDown();
            checkRecuperacao = new CheckBox();
            groupBox1 = new GroupBox();
            listQuestoes = new ListBox();
            btnSortearQuestoes = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtQtdQuestoes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.Location = new Point(42, 37);
            lbl.Name = "lbl";
            lbl.Size = new Size(50, 20);
            lbl.TabIndex = 0;
            lbl.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(98, 34);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(350, 27);
            txtTitulo.TabIndex = 1;
            // 
            // cmbDisciplinas
            // 
            cmbDisciplinas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDisciplinas.FormattingEnabled = true;
            cmbDisciplinas.Location = new Point(98, 81);
            cmbDisciplinas.Name = "cmbDisciplinas";
            cmbDisciplinas.Size = new Size(152, 23);
            cmbDisciplinas.TabIndex = 15;
            cmbDisciplinas.SelectedIndexChanged += cmbDisciplinas_SelectedIndexChanged;
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisciplina.Location = new Point(12, 81);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(80, 21);
            lblDisciplina.TabIndex = 14;
            lblDisciplina.Text = "Disciplina:";
            // 
            // cmbMaterias
            // 
            cmbMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterias.Enabled = false;
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(98, 120);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(152, 23);
            cmbMaterias.TabIndex = 17;
            // 
            // lblMaterias
            // 
            lblMaterias.AutoSize = true;
            lblMaterias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaterias.Location = new Point(19, 118);
            lblMaterias.Name = "lblMaterias";
            lblMaterias.Size = new Size(73, 21);
            lblMaterias.TabIndex = 16;
            lblMaterias.Text = "Materias:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 83);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 18;
            label1.Text = "Qtd. Questões:";
            // 
            // txtQtdQuestoes
            // 
            txtQtdQuestoes.Location = new Point(389, 83);
            txtQtdQuestoes.Name = "txtQtdQuestoes";
            txtQtdQuestoes.Size = new Size(59, 23);
            txtQtdQuestoes.TabIndex = 19;
            // 
            // checkRecuperacao
            // 
            checkRecuperacao.AutoSize = true;
            checkRecuperacao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkRecuperacao.Location = new Point(272, 120);
            checkRecuperacao.Name = "checkRecuperacao";
            checkRecuperacao.Size = new Size(176, 24);
            checkRecuperacao.TabIndex = 20;
            checkRecuperacao.Text = "Prova de Recuperação";
            checkRecuperacao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listQuestoes);
            groupBox1.Controls.Add(btnSortearQuestoes);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(42, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 260);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 20;
            listQuestoes.Location = new Point(0, 74);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(406, 184);
            listQuestoes.TabIndex = 1;
            // 
            // btnSortearQuestoes
            // 
            btnSortearQuestoes.Location = new Point(6, 26);
            btnSortearQuestoes.Name = "btnSortearQuestoes";
            btnSortearQuestoes.Size = new Size(160, 42);
            btnSortearQuestoes.TabIndex = 0;
            btnSortearQuestoes.Text = "Sortear Questões";
            btnSortearQuestoes.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(417, 437);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 31);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.AutoSize = true;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 12F);
            btnGravar.Location = new Point(330, 437);
            btnGravar.Margin = new Padding(3, 2, 3, 2);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(82, 31);
            btnGravar.TabIndex = 24;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(98, 6);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(53, 23);
            txtId.TabIndex = 26;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 479);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Controls.Add(checkRecuperacao);
            Controls.Add(txtQtdQuestoes);
            Controls.Add(label1);
            Controls.Add(cmbMaterias);
            Controls.Add(lblMaterias);
            Controls.Add(cmbDisciplinas);
            Controls.Add(lblDisciplina);
            Controls.Add(txtTitulo);
            Controls.Add(lbl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTesteForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Testes";
            ((System.ComponentModel.ISupportInitialize)txtQtdQuestoes).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private TextBox txtTitulo;
        private ComboBox cmbDisciplinas;
        private Label lblDisciplina;
        private ComboBox cmbMaterias;
        private Label lblMaterias;
        private Label label1;
        private NumericUpDown txtQtdQuestoes;
        private CheckBox checkRecuperacao;
        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnGravar;
        private Button btnSortearQuestoes;
        private ListBox listQuestoes;
        private TextBox txtId;
    }
}