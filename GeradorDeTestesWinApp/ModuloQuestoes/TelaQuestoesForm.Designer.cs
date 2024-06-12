namespace GeradorDeTestesWinApp.ModuloQuestoes
{
    partial class TelaQuestoesForm
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
            btnAdicionar = new Button();
            btnRemover = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtResposta = new TextBox();
            cmbMateria = new ComboBox();
            txtEnunciado = new TextBox();
            groupBox1 = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(424, 516);
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
            btnGravar.Location = new Point(324, 516);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 33);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSize = true;
            btnAdicionar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(422, 197);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(96, 50);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.AutoSize = true;
            btnRemover.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(10, 29);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(96, 33);
            btnRemover.TabIndex = 12;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 35);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 14;
            label1.Text = "Matéria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 112);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 15;
            label2.Text = "Enunciado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 215);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 16;
            label3.Text = "Resposta:";
            // 
            // txtResposta
            // 
            txtResposta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResposta.Location = new Point(118, 197);
            txtResposta.MaximumSize = new Size(400, 400);
            txtResposta.MinimumSize = new Size(250, 50);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(297, 50);
            txtResposta.TabIndex = 17;
            // 
            // cmbMateria
            // 
            cmbMateria.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(118, 32);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(255, 31);
            cmbMateria.TabIndex = 18;
            // 
            // txtEnunciado
            // 
            txtEnunciado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnunciado.Location = new Point(118, 78);
            txtEnunciado.MaximumSize = new Size(400, 400);
            txtEnunciado.MinimumSize = new Size(100, 100);
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(400, 100);
            txtEnunciado.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(btnRemover);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(30, 276);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(488, 218);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alternativas";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(11, 174);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(54, 27);
            checkBox4.TabIndex = 15;
            checkBox4.Text = "(D)";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(11, 141);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(53, 27);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "(C)";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(11, 108);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(52, 27);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "(B)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(11, 75);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(53, 27);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "(A)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // TelaQuestoesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 572);
            Controls.Add(groupBox1);
            Controls.Add(txtEnunciado);
            Controls.Add(cmbMateria);
            Controls.Add(txtResposta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdicionar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaQuestoesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Questões";
            Load += TelaQuestoesForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private Button btnAdicionar;
        private Button btnRemover;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtResposta;
        private ComboBox cmbMateria;
        private TextBox txtEnunciado;
        private GroupBox groupBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}