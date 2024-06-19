namespace GeradorDeTestesWinApp.ModuloTeste
{
    partial class TelaTesteDetalhadoForm
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
            btnFechar = new Button();
            groupBox1 = new GroupBox();
            listQuestoesSelecionadas = new ListBox();
            lblMaterias = new Label();
            lblDisciplina = new Label();
            lbl = new Label();
            lblTituloSelecionado = new Label();
            lblDisciplinaSelecionada = new Label();
            lblMateriaSelecionada = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.AutoSize = true;
            btnFechar.DialogResult = DialogResult.Cancel;
            btnFechar.Font = new Font("Segoe UI", 12F);
            btnFechar.Location = new Point(419, 555);
            btnFechar.Margin = new Padding(3, 2, 3, 2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(82, 31);
            btnFechar.TabIndex = 35;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listQuestoesSelecionadas);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(53, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 260);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // listQuestoesSelecionadas
            // 
            listQuestoesSelecionadas.FormattingEnabled = true;
            listQuestoesSelecionadas.ItemHeight = 20;
            listQuestoesSelecionadas.Location = new Point(0, 34);
            listQuestoesSelecionadas.Name = "listQuestoesSelecionadas";
            listQuestoesSelecionadas.Size = new Size(406, 224);
            listQuestoesSelecionadas.TabIndex = 1;
            // 
            // lblMaterias
            // 
            lblMaterias.AutoSize = true;
            lblMaterias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaterias.Location = new Point(30, 166);
            lblMaterias.Name = "lblMaterias";
            lblMaterias.Size = new Size(73, 21);
            lblMaterias.TabIndex = 29;
            lblMaterias.Text = "Materias:";
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisciplina.Location = new Point(23, 114);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(80, 21);
            lblDisciplina.TabIndex = 27;
            lblDisciplina.Text = "Disciplina:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.Location = new Point(53, 59);
            lbl.Name = "lbl";
            lbl.Size = new Size(50, 20);
            lbl.TabIndex = 25;
            lbl.Text = "Titulo:";
            // 
            // lblTituloSelecionado
            // 
            lblTituloSelecionado.AutoSize = true;
            lblTituloSelecionado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloSelecionado.Location = new Point(109, 59);
            lblTituloSelecionado.Name = "lblTituloSelecionado";
            lblTituloSelecionado.Size = new Size(133, 20);
            lblTituloSelecionado.TabIndex = 36;
            lblTituloSelecionado.Text = "[ Titulo do Teste ]";
            // 
            // lblDisciplinaSelecionada
            // 
            lblDisciplinaSelecionada.AutoSize = true;
            lblDisciplinaSelecionada.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisciplinaSelecionada.Location = new Point(109, 115);
            lblDisciplinaSelecionada.Name = "lblDisciplinaSelecionada";
            lblDisciplinaSelecionada.Size = new Size(182, 20);
            lblDisciplinaSelecionada.TabIndex = 37;
            lblDisciplinaSelecionada.Text = "[ Disciplina Selecionada ]";
            // 
            // lblMateriaSelecionada
            // 
            lblMateriaSelecionada.AutoSize = true;
            lblMateriaSelecionada.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMateriaSelecionada.Location = new Point(109, 166);
            lblMateriaSelecionada.Name = "lblMateriaSelecionada";
            lblMateriaSelecionada.Size = new Size(169, 20);
            lblMateriaSelecionada.TabIndex = 38;
            lblMateriaSelecionada.Text = "[ Materia Selecionada ]";
            // 
            // TelaTesteDetalhadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnFechar;
            ClientSize = new Size(513, 597);
            Controls.Add(lblMateriaSelecionada);
            Controls.Add(lblDisciplinaSelecionada);
            Controls.Add(lblTituloSelecionado);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Controls.Add(lblMaterias);
            Controls.Add(lblDisciplina);
            Controls.Add(lbl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTesteDetalhadoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Visualização de Testes";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private GroupBox groupBox1;
        private ListBox listQuestoesSelecionadas;
        private Label lblMaterias;
        private Label lblDisciplina;
        private Label lbl;
        private Label lblTituloSelecionado;
        private Label lblDisciplinaSelecionada;
        private Label lblMateriaSelecionada;
    }
}