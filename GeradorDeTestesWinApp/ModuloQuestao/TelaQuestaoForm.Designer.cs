﻿namespace GeradorDeTestesWinApp.ModuloQuestao
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
            gpbAlternativas = new GroupBox();
            txtAlternativaE = new TextBox();
            checkAlternativaE = new CheckBox();
            txtAlternativaD = new TextBox();
            txtAlternativaC = new TextBox();
            txtAlternativaB = new TextBox();
            txtAlternativaA = new TextBox();
            checkAlternativaD = new CheckBox();
            checkAlternativaC = new CheckBox();
            checkAlternativaB = new CheckBox();
            checkAlternativaA = new CheckBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtId = new TextBox();
            btnRemoverA = new Button();
            btnRemoverB = new Button();
            btnRemoverC = new Button();
            btnRemoverD = new Button();
            btnReverterD = new Button();
            btnReverterC = new Button();
            btnReverterB = new Button();
            btnReverterA = new Button();
            btnAdicionarCampo = new Button();
            btnRemoverE = new Button();
            gpbAlternativas.SuspendLayout();
            SuspendLayout();
            // 
            // cmbMaterias
            // 
            cmbMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(91, 31);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(152, 23);
            cmbMaterias.TabIndex = 0;
            // 
            // lblMaterias
            // 
            lblMaterias.AutoSize = true;
            lblMaterias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaterias.Location = new Point(12, 29);
            lblMaterias.Name = "lblMaterias";
            lblMaterias.Size = new Size(73, 21);
            lblMaterias.TabIndex = 14;
            lblMaterias.Text = "Materias:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 119);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 16;
            label1.Text = "Enunciado:";
            // 
            // txtEnunciado
            // 
            txtEnunciado.Location = new Point(91, 80);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(363, 108);
            txtEnunciado.TabIndex = 1;
            // 
            // gpbAlternativas
            // 
            gpbAlternativas.Controls.Add(btnRemoverE);
            gpbAlternativas.Controls.Add(txtAlternativaE);
            gpbAlternativas.Controls.Add(btnAdicionarCampo);
            gpbAlternativas.Controls.Add(checkAlternativaE);
            gpbAlternativas.Controls.Add(btnReverterD);
            gpbAlternativas.Controls.Add(txtAlternativaD);
            gpbAlternativas.Controls.Add(btnReverterC);
            gpbAlternativas.Controls.Add(txtAlternativaC);
            gpbAlternativas.Controls.Add(btnReverterB);
            gpbAlternativas.Controls.Add(txtAlternativaB);
            gpbAlternativas.Controls.Add(btnReverterA);
            gpbAlternativas.Controls.Add(txtAlternativaA);
            gpbAlternativas.Controls.Add(btnRemoverD);
            gpbAlternativas.Controls.Add(checkAlternativaD);
            gpbAlternativas.Controls.Add(btnRemoverC);
            gpbAlternativas.Controls.Add(checkAlternativaC);
            gpbAlternativas.Controls.Add(btnRemoverB);
            gpbAlternativas.Controls.Add(checkAlternativaB);
            gpbAlternativas.Controls.Add(btnRemoverA);
            gpbAlternativas.Controls.Add(checkAlternativaA);
            gpbAlternativas.Location = new Point(12, 204);
            gpbAlternativas.Name = "gpbAlternativas";
            gpbAlternativas.Size = new Size(513, 185);
            gpbAlternativas.TabIndex = 21;
            gpbAlternativas.TabStop = false;
            gpbAlternativas.Text = "Alternativas";
            // 
            // txtAlternativaE
            // 
            txtAlternativaE.Enabled = false;
            txtAlternativaE.Location = new Point(79, 145);
            txtAlternativaE.Multiline = true;
            txtAlternativaE.Name = "txtAlternativaE";
            txtAlternativaE.Size = new Size(363, 23);
            txtAlternativaE.TabIndex = 6;
            txtAlternativaE.Visible = false;
            // 
            // checkAlternativaE
            // 
            checkAlternativaE.AutoSize = true;
            checkAlternativaE.Enabled = false;
            checkAlternativaE.Location = new Point(15, 148);
            checkAlternativaE.Name = "checkAlternativaE";
            checkAlternativaE.Size = new Size(56, 19);
            checkAlternativaE.TabIndex = 8;
            checkAlternativaE.TabStop = false;
            checkAlternativaE.Text = "(E) ->";
            checkAlternativaE.UseVisualStyleBackColor = true;
            checkAlternativaE.Visible = false;
            // 
            // txtAlternativaD
            // 
            txtAlternativaD.Location = new Point(79, 116);
            txtAlternativaD.Multiline = true;
            txtAlternativaD.Name = "txtAlternativaD";
            txtAlternativaD.Size = new Size(363, 23);
            txtAlternativaD.TabIndex = 5;
            // 
            // txtAlternativaC
            // 
            txtAlternativaC.Location = new Point(79, 84);
            txtAlternativaC.Multiline = true;
            txtAlternativaC.Name = "txtAlternativaC";
            txtAlternativaC.Size = new Size(363, 23);
            txtAlternativaC.TabIndex = 4;
            // 
            // txtAlternativaB
            // 
            txtAlternativaB.Location = new Point(78, 52);
            txtAlternativaB.Multiline = true;
            txtAlternativaB.Name = "txtAlternativaB";
            txtAlternativaB.Size = new Size(363, 23);
            txtAlternativaB.TabIndex = 3;
            // 
            // txtAlternativaA
            // 
            txtAlternativaA.Location = new Point(79, 20);
            txtAlternativaA.Multiline = true;
            txtAlternativaA.Name = "txtAlternativaA";
            txtAlternativaA.Size = new Size(363, 23);
            txtAlternativaA.TabIndex = 2;
            // 
            // checkAlternativaD
            // 
            checkAlternativaD.AutoSize = true;
            checkAlternativaD.Location = new Point(15, 119);
            checkAlternativaD.Name = "checkAlternativaD";
            checkAlternativaD.Size = new Size(58, 19);
            checkAlternativaD.TabIndex = 3;
            checkAlternativaD.TabStop = false;
            checkAlternativaD.Text = "(D) ->";
            checkAlternativaD.UseVisualStyleBackColor = true;
            // 
            // checkAlternativaC
            // 
            checkAlternativaC.AutoSize = true;
            checkAlternativaC.Location = new Point(15, 86);
            checkAlternativaC.Name = "checkAlternativaC";
            checkAlternativaC.Size = new Size(58, 19);
            checkAlternativaC.TabIndex = 2;
            checkAlternativaC.TabStop = false;
            checkAlternativaC.Text = "(C) ->";
            checkAlternativaC.UseVisualStyleBackColor = true;
            // 
            // checkAlternativaB
            // 
            checkAlternativaB.AutoSize = true;
            checkAlternativaB.Location = new Point(15, 56);
            checkAlternativaB.Name = "checkAlternativaB";
            checkAlternativaB.Size = new Size(57, 19);
            checkAlternativaB.TabIndex = 1;
            checkAlternativaB.TabStop = false;
            checkAlternativaB.Text = "(B) ->";
            checkAlternativaB.UseVisualStyleBackColor = true;
            // 
            // checkAlternativaA
            // 
            checkAlternativaA.AutoSize = true;
            checkAlternativaA.Location = new Point(15, 22);
            checkAlternativaA.Name = "checkAlternativaA";
            checkAlternativaA.Size = new Size(58, 19);
            checkAlternativaA.TabIndex = 0;
            checkAlternativaA.TabStop = false;
            checkAlternativaA.Text = "(A) ->";
            checkAlternativaA.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(453, 421);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 31);
            btnCancelar.TabIndex = 99;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.AutoSize = true;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 12F);
            btnGravar.Location = new Point(366, 421);
            btnGravar.Margin = new Padding(3, 2, 3, 2);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(82, 31);
            btnGravar.TabIndex = 98;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(249, 32);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(53, 23);
            txtId.TabIndex = 25;
            // 
            // btnRemoverA
            // 
            btnRemoverA.Image = Properties.Resources.btnExcluir;
            btnRemoverA.Location = new Point(447, 20);
            btnRemoverA.Name = "btnRemoverA";
            btnRemoverA.Size = new Size(28, 24);
            btnRemoverA.TabIndex = 26;
            btnRemoverA.TabStop = false;
            btnRemoverA.UseVisualStyleBackColor = true;
            btnRemoverA.Click += btnRemoverA_Click;
            // 
            // btnRemoverB
            // 
            btnRemoverB.Image = Properties.Resources.btnExcluir;
            btnRemoverB.Location = new Point(447, 53);
            btnRemoverB.Name = "btnRemoverB";
            btnRemoverB.Size = new Size(28, 24);
            btnRemoverB.TabIndex = 27;
            btnRemoverB.TabStop = false;
            btnRemoverB.UseVisualStyleBackColor = true;
            btnRemoverB.Click += btnRemoverB_Click;
            // 
            // btnRemoverC
            // 
            btnRemoverC.Image = Properties.Resources.btnExcluir;
            btnRemoverC.Location = new Point(447, 85);
            btnRemoverC.Name = "btnRemoverC";
            btnRemoverC.Size = new Size(28, 24);
            btnRemoverC.TabIndex = 28;
            btnRemoverC.TabStop = false;
            btnRemoverC.UseVisualStyleBackColor = true;
            btnRemoverC.Click += btnRemoverC_Click;
            // 
            // btnRemoverD
            // 
            btnRemoverD.Image = Properties.Resources.btnExcluir;
            btnRemoverD.Location = new Point(447, 117);
            btnRemoverD.Name = "btnRemoverD";
            btnRemoverD.Size = new Size(28, 24);
            btnRemoverD.TabIndex = 29;
            btnRemoverD.TabStop = false;
            btnRemoverD.UseVisualStyleBackColor = true;
            btnRemoverD.Click += btnRemoverD_Click;
            // 
            // btnReverterD
            // 
            btnReverterD.Image = Properties.Resources.btnReverterAcao;
            btnReverterD.Location = new Point(481, 118);
            btnReverterD.Name = "btnReverterD";
            btnReverterD.Size = new Size(28, 24);
            btnReverterD.TabIndex = 33;
            btnReverterD.TabStop = false;
            btnReverterD.UseVisualStyleBackColor = true;
            btnReverterD.Click += btnReverterD_Click;
            // 
            // btnReverterC
            // 
            btnReverterC.Image = Properties.Resources.btnReverterAcao;
            btnReverterC.Location = new Point(481, 86);
            btnReverterC.Name = "btnReverterC";
            btnReverterC.Size = new Size(28, 24);
            btnReverterC.TabIndex = 32;
            btnReverterC.TabStop = false;
            btnReverterC.UseVisualStyleBackColor = true;
            btnReverterC.Click += btnReverterC_Click;
            // 
            // btnReverterB
            // 
            btnReverterB.Image = Properties.Resources.btnReverterAcao;
            btnReverterB.Location = new Point(481, 54);
            btnReverterB.Name = "btnReverterB";
            btnReverterB.Size = new Size(28, 24);
            btnReverterB.TabIndex = 31;
            btnReverterB.TabStop = false;
            btnReverterB.UseVisualStyleBackColor = true;
            btnReverterB.Click += btnReverterB_Click;
            // 
            // btnReverterA
            // 
            btnReverterA.Image = Properties.Resources.btnReverterAcao;
            btnReverterA.Location = new Point(481, 21);
            btnReverterA.Name = "btnReverterA";
            btnReverterA.Size = new Size(28, 24);
            btnReverterA.TabIndex = 30;
            btnReverterA.TabStop = false;
            btnReverterA.UseVisualStyleBackColor = true;
            btnReverterA.Click += btnReverterA_Click;
            // 
            // btnAdicionarCampo
            // 
            btnAdicionarCampo.Image = Properties.Resources.btnAdicionar1;
            btnAdicionarCampo.Location = new Point(447, 145);
            btnAdicionarCampo.Name = "btnAdicionarCampo";
            btnAdicionarCampo.Size = new Size(28, 28);
            btnAdicionarCampo.TabIndex = 34;
            btnAdicionarCampo.TabStop = false;
            btnAdicionarCampo.UseVisualStyleBackColor = true;
            btnAdicionarCampo.Click += btnAdicionarCampo_Click;
            // 
            // btnRemoverE
            // 
            btnRemoverE.Image = Properties.Resources.btnExcluir;
            btnRemoverE.Location = new Point(481, 148);
            btnRemoverE.Name = "btnRemoverE";
            btnRemoverE.Size = new Size(28, 24);
            btnRemoverE.TabIndex = 35;
            btnRemoverE.TabStop = false;
            btnRemoverE.UseVisualStyleBackColor = true;
            btnRemoverE.Visible = false;
            btnRemoverE.Click += btnRemoverE_Click;
            // 
            // TelaQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 463);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(gpbAlternativas);
            Controls.Add(txtEnunciado);
            Controls.Add(label1);
            Controls.Add(cmbMaterias);
            Controls.Add(lblMaterias);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private GroupBox gpbAlternativas;
        private CheckBox checkAlternativaD;
        private CheckBox checkAlternativaC;
        private CheckBox checkAlternativaB;
        private CheckBox checkAlternativaA;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtAlternativaD;
        private TextBox txtAlternativaC;
        private TextBox txtAlternativaB;
        private TextBox txtAlternativaA;
        private TextBox txtId;
        private Button btnRemoverA;
        private Button btnRemoverB;
        private Button btnRemoverC;
        private Button btnRemoverD;
        private Button btnReverterD;
        private Button btnReverterC;
        private Button btnReverterB;
        private Button btnReverterA;
        private Button btnAdicionarCampo;
        private TextBox txtAlternativaE;
        private CheckBox checkAlternativaE;
        private Button btnRemoverE;
    }
}