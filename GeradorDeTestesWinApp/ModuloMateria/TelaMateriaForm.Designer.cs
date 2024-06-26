﻿namespace GeradorDeTestesWinApp.ModuloMateria
{
    partial class TelaMateriaForm
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
            lblId = new Label();
            lblNome = new Label();
            lblDisciplina = new Label();
            lblSerie = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtId = new TextBox();
            txtNome = new TextBox();
            rdb1Serie = new RadioButton();
            rdb2Serie = new RadioButton();
            cmbDisciplinas = new ComboBox();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(83, 26);
            lblId.Name = "lblId";
            lblId.Size = new Size(26, 21);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(53, 56);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisciplina.Location = new Point(29, 86);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(80, 21);
            lblDisciplina.TabIndex = 2;
            lblDisciplina.Text = "Disciplina:";
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSerie.Location = new Point(61, 114);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(48, 21);
            lblSerie.TabIndex = 3;
            lblSerie.Text = "Série:";
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(349, 167);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 31);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.AutoSize = true;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 12F);
            btnGravar.Location = new Point(262, 167);
            btnGravar.Margin = new Padding(3, 2, 3, 2);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(82, 31);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(115, 28);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(53, 23);
            txtId.TabIndex = 7;
            txtId.Text = "0";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(115, 58);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(316, 23);
            txtNome.TabIndex = 0;
            // 
            // rdb1Serie
            // 
            rdb1Serie.AutoSize = true;
            rdb1Serie.Font = new Font("Segoe UI", 10.2F);
            rdb1Serie.Location = new Point(115, 114);
            rdb1Serie.Margin = new Padding(3, 2, 3, 2);
            rdb1Serie.Name = "rdb1Serie";
            rdb1Serie.Size = new Size(73, 23);
            rdb1Serie.TabIndex = 2;
            rdb1Serie.TabStop = true;
            rdb1Serie.Text = "1ª Série";
            rdb1Serie.UseVisualStyleBackColor = true;
            // 
            // rdb2Serie
            // 
            rdb2Serie.AutoSize = true;
            rdb2Serie.Font = new Font("Segoe UI", 10.2F);
            rdb2Serie.Location = new Point(194, 114);
            rdb2Serie.Margin = new Padding(3, 2, 3, 2);
            rdb2Serie.Name = "rdb2Serie";
            rdb2Serie.Size = new Size(73, 23);
            rdb2Serie.TabIndex = 3;
            rdb2Serie.TabStop = true;
            rdb2Serie.Text = "2ª Série";
            rdb2Serie.UseVisualStyleBackColor = true;
            // 
            // cmbDisciplinas
            // 
            cmbDisciplinas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDisciplinas.FormattingEnabled = true;
            cmbDisciplinas.Location = new Point(115, 86);
            cmbDisciplinas.Name = "cmbDisciplinas";
            cmbDisciplinas.Size = new Size(152, 23);
            cmbDisciplinas.TabIndex = 1;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 208);
            Controls.Add(cmbDisciplinas);
            Controls.Add(rdb2Serie);
            Controls.Add(rdb1Serie);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(lblSerie);
            Controls.Add(lblDisciplina);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaMateriaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Matérias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Label lblDisciplina;
        private Label lblSerie;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtId;
        private TextBox txtNome;
        private RadioButton rdb1Serie;
        private RadioButton rdb2Serie;
        private ComboBox cmbDisciplinas;
    }
}