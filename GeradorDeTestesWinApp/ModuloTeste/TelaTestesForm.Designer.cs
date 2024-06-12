namespace GeradorDeTestesWinApp.ModuloTeste
{
    partial class TelaTestesForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            btnSortearQuestoes = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbMateria = new ComboBox();
            comboBox1 = new ComboBox();
            chBProvaRecuperacao = new CheckBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            domainUpQtdQuestoes = new DomainUpDown();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(467, 602);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 33);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.AutoSize = true;
            btnGravar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(367, 602);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 33);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 49);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 14;
            label1.Text = "Título:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 103);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 15;
            label2.Text = "Disciplina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 164);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 16;
            label3.Text = "Matéria:";
            // 
            // cmbMateria
            // 
            cmbMateria.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(104, 101);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(255, 31);
            cmbMateria.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(104, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 31);
            comboBox1.TabIndex = 20;
            // 
            // chBProvaRecuperacao
            // 
            chBProvaRecuperacao.AutoSize = true;
            chBProvaRecuperacao.Location = new Point(372, 164);
            chBProvaRecuperacao.Name = "chBProvaRecuperacao";
            chBProvaRecuperacao.Size = new Size(179, 24);
            chBProvaRecuperacao.TabIndex = 21;
            chBProvaRecuperacao.Text = "Prova de Recuperação";
            chBProvaRecuperacao.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(375, 105);
            label4.Name = "label4";
            label4.Size = new Size(123, 23);
            label4.TabIndex = 22;
            label4.Text = "Qtd. Questões:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSortearQuestoes);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(43, 255);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(518, 321);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 27);
            textBox1.TabIndex = 24;
            // 
            // domainUpQtdQuestoes
            // 
            domainUpQtdQuestoes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            domainUpQtdQuestoes.Location = new Point(500, 103);
            domainUpQtdQuestoes.Name = "domainUpQtdQuestoes";
            domainUpQtdQuestoes.Size = new Size(54, 30);
            domainUpQtdQuestoes.TabIndex = 25;
            // 
            // TelaTestesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 661);
            Controls.Add(domainUpQtdQuestoes);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(chBProvaRecuperacao);
            Controls.Add(comboBox1);
            Controls.Add(cmbMateria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaTestesForm";
            Text = "Cadastro de Testes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private Button btnSortearQuestoes;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbMateria;
        private ComboBox comboBox1;
        private CheckBox chBProvaRecuperacao;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private DomainUpDown domainUpQtdQuestoes;
    }
}