namespace GeradorDeTestesWinApp.ModuloQuestao
{
    partial class TelaQuestaoForm
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
            cmbMaterias = new ComboBox();
            lblMaterias = new Label();
            label1 = new Label();
            txtEnunciado = new TextBox();
            label2 = new Label();
            txtResposta = new TextBox();
            btnAdicionar = new Button();
            gpbAlternativas = new GroupBox();
            checkAlternativaD = new CheckBox();
            checkAlternativaC = new CheckBox();
            checkAlternativaB = new CheckBox();
            checkAlternativaA = new CheckBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            gpbAlternativas.SuspendLayout();
            SuspendLayout();
            // 
            // cmbMaterias
            // 
            cmbMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(91, 11);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(152, 23);
            cmbMaterias.TabIndex = 15;
            // 
            // lblMaterias
            // 
            lblMaterias.AutoSize = true;
            lblMaterias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaterias.Location = new Point(12, 9);
            lblMaterias.Name = "lblMaterias";
            lblMaterias.Size = new Size(73, 21);
            lblMaterias.TabIndex = 14;
            lblMaterias.Text = "Materias:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 79);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 16;
            label1.Text = "Enunciado:";
            // 
            // txtEnunciado
            // 
            txtEnunciado.Location = new Point(91, 40);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(364, 108);
            txtEnunciado.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 18;
            label2.Text = "Resposta:";
            // 
            // txtResposta
            // 
            txtResposta.Location = new Point(91, 154);
            txtResposta.Multiline = true;
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(364, 50);
            txtResposta.TabIndex = 19;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(91, 210);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(364, 32);
            btnAdicionar.TabIndex = 20;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // gpbAlternativas
            // 
            gpbAlternativas.Controls.Add(checkAlternativaD);
            gpbAlternativas.Controls.Add(checkAlternativaC);
            gpbAlternativas.Controls.Add(checkAlternativaB);
            gpbAlternativas.Controls.Add(checkAlternativaA);
            gpbAlternativas.Location = new Point(91, 261);
            gpbAlternativas.Name = "gpbAlternativas";
            gpbAlternativas.Size = new Size(364, 125);
            gpbAlternativas.TabIndex = 21;
            gpbAlternativas.TabStop = false;
            gpbAlternativas.Text = "Alternativas";
            // 
            // checkAlternativaD
            // 
            checkAlternativaD.AutoSize = true;
            checkAlternativaD.Location = new Point(6, 97);
            checkAlternativaD.Name = "checkAlternativaD";
            checkAlternativaD.Size = new Size(58, 19);
            checkAlternativaD.TabIndex = 3;
            checkAlternativaD.Text = "(D) ->";
            checkAlternativaD.UseVisualStyleBackColor = true;
            // 
            // checkAlternativaC
            // 
            checkAlternativaC.AutoSize = true;
            checkAlternativaC.Location = new Point(6, 72);
            checkAlternativaC.Name = "checkAlternativaC";
            checkAlternativaC.Size = new Size(58, 19);
            checkAlternativaC.TabIndex = 2;
            checkAlternativaC.Text = "(C) ->";
            checkAlternativaC.UseVisualStyleBackColor = true;
            // 
            // checkAlternativaB
            // 
            checkAlternativaB.AutoSize = true;
            checkAlternativaB.Location = new Point(6, 47);
            checkAlternativaB.Name = "checkAlternativaB";
            checkAlternativaB.Size = new Size(57, 19);
            checkAlternativaB.TabIndex = 1;
            checkAlternativaB.Text = "(B) ->";
            checkAlternativaB.UseVisualStyleBackColor = true;
            // 
            // checkAlternativaA
            // 
            checkAlternativaA.AutoSize = true;
            checkAlternativaA.Location = new Point(6, 22);
            checkAlternativaA.Name = "checkAlternativaA";
            checkAlternativaA.Size = new Size(58, 19);
            checkAlternativaA.TabIndex = 0;
            checkAlternativaA.Text = "(A) ->";
            checkAlternativaA.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(450, 433);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 31);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.AutoSize = true;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 12F);
            btnGravar.Location = new Point(363, 433);
            btnGravar.Margin = new Padding(3, 2, 3, 2);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(82, 31);
            btnGravar.TabIndex = 22;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 475);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(gpbAlternativas);
            Controls.Add(btnAdicionar);
            Controls.Add(txtResposta);
            Controls.Add(label2);
            Controls.Add(txtEnunciado);
            Controls.Add(label1);
            Controls.Add(cmbMaterias);
            Controls.Add(lblMaterias);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaQuestaoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Questões";
            gpbAlternativas.ResumeLayout(false);
            gpbAlternativas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMaterias;
        private Label lblMaterias;
        private Label label1;
        private TextBox txtEnunciado;
        private Label label2;
        private TextBox txtResposta;
        private Button btnAdicionar;
        private GroupBox gpbAlternativas;
        private CheckBox checkAlternativaD;
        private CheckBox checkAlternativaC;
        private CheckBox checkAlternativaB;
        private CheckBox checkAlternativaA;
        private Button btnCancelar;
        private Button btnGravar;
    }
}