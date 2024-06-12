namespace GeradorDeTestesWinApp.ModuloMateria
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
            txtDisciplina = new TextBox();
            rdb1Serie = new RadioButton();
            rdb2Serie = new RadioButton();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(93, 27);
            lblId.Name = "lblId";
            lblId.Size = new Size(33, 28);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(56, 75);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 28);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisciplina.Location = new Point(26, 118);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(100, 28);
            lblDisciplina.TabIndex = 2;
            lblDisciplina.Text = "Disciplina:";
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSerie.Location = new Point(67, 168);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(59, 28);
            lblSerie.TabIndex = 3;
            lblSerie.Text = "Série:";
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(399, 247);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 33);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.AutoSize = true;
            btnGravar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(299, 247);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 33);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(132, 31);
            txtId.Name = "txtId";
            txtId.Size = new Size(60, 27);
            txtId.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(132, 76);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(361, 27);
            txtNome.TabIndex = 8;
            // 
            // txtDisciplina
            // 
            txtDisciplina.Location = new Point(132, 122);
            txtDisciplina.Name = "txtDisciplina";
            txtDisciplina.Size = new Size(361, 27);
            txtDisciplina.TabIndex = 9;
            // 
            // rdb1Serie
            // 
            rdb1Serie.AutoSize = true;
            rdb1Serie.Font = new Font("Segoe UI", 10.2F);
            rdb1Serie.Location = new Point(132, 169);
            rdb1Serie.Name = "rdb1Serie";
            rdb1Serie.Size = new Size(89, 27);
            rdb1Serie.TabIndex = 11;
            rdb1Serie.TabStop = true;
            rdb1Serie.Text = "1ª Série";
            rdb1Serie.UseVisualStyleBackColor = true;
            // 
            // rdb2Serie
            // 
            rdb2Serie.AutoSize = true;
            rdb2Serie.Font = new Font("Segoe UI", 10.2F);
            rdb2Serie.Location = new Point(228, 169);
            rdb2Serie.Name = "rdb2Serie";
            rdb2Serie.Size = new Size(89, 27);
            rdb2Serie.TabIndex = 12;
            rdb2Serie.TabStop = true;
            rdb2Serie.Text = "2ª Série";
            rdb2Serie.UseVisualStyleBackColor = true;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 329);
            Controls.Add(rdb2Serie);
            Controls.Add(rdb1Serie);
            Controls.Add(txtDisciplina);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(lblSerie);
            Controls.Add(lblDisciplina);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Name = "TelaMateriaForm";
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
        private TextBox txtDisciplina;
        private RadioButton rdb1Serie;
        private RadioButton rdb2Serie;
    }
}