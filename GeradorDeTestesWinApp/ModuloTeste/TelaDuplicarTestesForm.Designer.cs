namespace GeradorDeTestesWinApp.ModuloTeste
{
    partial class TelaDuplicarTestesForm
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
            domainUpQtdQuestoes = new DomainUpDown();
            txtTituloDuplicarTestes = new TextBox();
            groupBox1 = new GroupBox();
            listBoxDuplicarTestes = new ListBox();
            btnSortearQuestoes = new Button();
            lblQtdQuestoesDuplicar = new Label();
            chBProvaRecuperacaoDuplicar = new CheckBox();
            cmbBoxMateriaDuplicarTestes = new ComboBox();
            cmbBoxDisciplinaDuplicarTestes = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // domainUpQtdQuestoes
            // 
            domainUpQtdQuestoes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            domainUpQtdQuestoes.Location = new Point(502, 86);
            domainUpQtdQuestoes.Name = "domainUpQtdQuestoes";
            domainUpQtdQuestoes.Size = new Size(54, 30);
            domainUpQtdQuestoes.TabIndex = 37;
            // 
            // txtTituloDuplicarTestes
            // 
            txtTituloDuplicarTestes.Location = new Point(106, 32);
            txtTituloDuplicarTestes.Name = "txtTituloDuplicarTestes";
            txtTituloDuplicarTestes.Size = new Size(450, 27);
            txtTituloDuplicarTestes.TabIndex = 36;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxDuplicarTestes);
            groupBox1.Controls.Add(btnSortearQuestoes);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(45, 238);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(518, 273);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // listBoxDuplicarTestes
            // 
            listBoxDuplicarTestes.FormattingEnabled = true;
            listBoxDuplicarTestes.ItemHeight = 23;
            listBoxDuplicarTestes.Location = new Point(3, 62);
            listBoxDuplicarTestes.Name = "listBoxDuplicarTestes";
            listBoxDuplicarTestes.Size = new Size(511, 211);
            listBoxDuplicarTestes.TabIndex = 14;
            // 
            // btnSortearQuestoes
            // 
            btnSortearQuestoes.AutoSize = true;
            btnSortearQuestoes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSortearQuestoes.Location = new Point(6, 29);
            btnSortearQuestoes.Name = "btnSortearQuestoes";
            btnSortearQuestoes.Size = new Size(151, 33);
            btnSortearQuestoes.TabIndex = 13;
            btnSortearQuestoes.Text = "Sortear Questões";
            btnSortearQuestoes.UseVisualStyleBackColor = true;
            // 
            // lblQtdQuestoesDuplicar
            // 
            lblQtdQuestoesDuplicar.AutoSize = true;
            lblQtdQuestoesDuplicar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQtdQuestoesDuplicar.Location = new Point(377, 88);
            lblQtdQuestoesDuplicar.Name = "lblQtdQuestoesDuplicar";
            lblQtdQuestoesDuplicar.Size = new Size(123, 23);
            lblQtdQuestoesDuplicar.TabIndex = 34;
            lblQtdQuestoesDuplicar.Text = "Qtd. Questões:";
            // 
            // chBProvaRecuperacaoDuplicar
            // 
            chBProvaRecuperacaoDuplicar.AutoSize = true;
            chBProvaRecuperacaoDuplicar.Location = new Point(374, 147);
            chBProvaRecuperacaoDuplicar.Name = "chBProvaRecuperacaoDuplicar";
            chBProvaRecuperacaoDuplicar.Size = new Size(179, 24);
            chBProvaRecuperacaoDuplicar.TabIndex = 33;
            chBProvaRecuperacaoDuplicar.Text = "Prova de Recuperação";
            chBProvaRecuperacaoDuplicar.UseVisualStyleBackColor = true;
            // 
            // cmbBoxMateriaDuplicarTestes
            // 
            cmbBoxMateriaDuplicarTestes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxMateriaDuplicarTestes.FormattingEnabled = true;
            cmbBoxMateriaDuplicarTestes.Location = new Point(106, 144);
            cmbBoxMateriaDuplicarTestes.Name = "cmbBoxMateriaDuplicarTestes";
            cmbBoxMateriaDuplicarTestes.Size = new Size(255, 31);
            cmbBoxMateriaDuplicarTestes.TabIndex = 32;
            // 
            // cmbBoxDisciplinaDuplicarTestes
            // 
            cmbBoxDisciplinaDuplicarTestes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxDisciplinaDuplicarTestes.FormattingEnabled = true;
            cmbBoxDisciplinaDuplicarTestes.Location = new Point(106, 84);
            cmbBoxDisciplinaDuplicarTestes.Name = "cmbBoxDisciplinaDuplicarTestes";
            cmbBoxDisciplinaDuplicarTestes.Size = new Size(255, 31);
            cmbBoxDisciplinaDuplicarTestes.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 147);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 30;
            label3.Text = "Matéria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 86);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 29;
            label2.Text = "Disciplina:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 32);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 28;
            label1.Text = "Título:";
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(469, 539);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 33);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.AutoSize = true;
            btnGravar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(369, 539);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 33);
            btnGravar.TabIndex = 26;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // TelaDuplicarTestesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 600);
            Controls.Add(domainUpQtdQuestoes);
            Controls.Add(txtTituloDuplicarTestes);
            Controls.Add(groupBox1);
            Controls.Add(lblQtdQuestoesDuplicar);
            Controls.Add(chBProvaRecuperacaoDuplicar);
            Controls.Add(cmbBoxMateriaDuplicarTestes);
            Controls.Add(cmbBoxDisciplinaDuplicarTestes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDuplicarTestesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Duplicação de Testes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DomainUpDown domainUpQtdQuestoes;
        private TextBox txtTituloDuplicarTestes;
        private GroupBox groupBox1;
        private Button btnSortearQuestoes;
        private Label lblQtdQuestoesDuplicar;
        private CheckBox chBProvaRecuperacaoDuplicar;
        private ComboBox cmbBoxMateriaDuplicarTestes;
        private ComboBox cmbBoxDisciplinaDuplicarTestes;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private ListBox listBoxDuplicarTestes;
    }
}