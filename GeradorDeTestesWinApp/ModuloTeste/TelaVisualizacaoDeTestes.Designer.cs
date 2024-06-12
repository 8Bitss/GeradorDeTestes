namespace GeradorDeTestesWinApp.ModuloTeste
{
    partial class TelaVisualizacaoDeTestes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbBoxDisciplinaVisuzlizarTestes = new ComboBox();
            cmbBoxMateriaVisualizarTestes = new ComboBox();
            txtTituloVisualizarTestes = new TextBox();
            listBoxVisualizarTestes = new ListBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.AutoSize = true;
            btnFechar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(464, 487);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 33);
            btnFechar.TabIndex = 37;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 26);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 38;
            label1.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 80);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 39;
            label2.Text = "Disciplina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 141);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 40;
            label3.Text = "Matéria:";
            // 
            // cmbBoxDisciplinaVisuzlizarTestes
            // 
            cmbBoxDisciplinaVisuzlizarTestes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxDisciplinaVisuzlizarTestes.FormattingEnabled = true;
            cmbBoxDisciplinaVisuzlizarTestes.Location = new Point(105, 78);
            cmbBoxDisciplinaVisuzlizarTestes.Name = "cmbBoxDisciplinaVisuzlizarTestes";
            cmbBoxDisciplinaVisuzlizarTestes.Size = new Size(255, 31);
            cmbBoxDisciplinaVisuzlizarTestes.TabIndex = 41;
            // 
            // cmbBoxMateriaVisualizarTestes
            // 
            cmbBoxMateriaVisualizarTestes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxMateriaVisualizarTestes.FormattingEnabled = true;
            cmbBoxMateriaVisualizarTestes.Location = new Point(105, 138);
            cmbBoxMateriaVisualizarTestes.Name = "cmbBoxMateriaVisualizarTestes";
            cmbBoxMateriaVisualizarTestes.Size = new Size(255, 31);
            cmbBoxMateriaVisualizarTestes.TabIndex = 42;
            // 
            // txtTituloVisualizarTestes
            // 
            txtTituloVisualizarTestes.Location = new Point(105, 26);
            txtTituloVisualizarTestes.Name = "txtTituloVisualizarTestes";
            txtTituloVisualizarTestes.Size = new Size(450, 27);
            txtTituloVisualizarTestes.TabIndex = 46;
            // 
            // listBoxVisualizarTestes
            // 
            listBoxVisualizarTestes.FormattingEnabled = true;
            listBoxVisualizarTestes.ItemHeight = 23;
            listBoxVisualizarTestes.Location = new Point(3, 39);
            listBoxVisualizarTestes.Name = "listBoxVisualizarTestes";
            listBoxVisualizarTestes.Size = new Size(511, 234);
            listBoxVisualizarTestes.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxVisualizarTestes);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(44, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(518, 273);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // TelaVisualizacaoDeTestes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 540);
            Controls.Add(txtTituloVisualizarTestes);
            Controls.Add(groupBox1);
            Controls.Add(cmbBoxMateriaVisualizarTestes);
            Controls.Add(cmbBoxDisciplinaVisuzlizarTestes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFechar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaVisualizacaoDeTestes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Visualização de Testes";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbBoxDisciplinaVisuzlizarTestes;
        private ComboBox cmbBoxMateriaVisualizarTestes;
        private TextBox txtTituloVisualizarTestes;
        private ListBox listBoxVisualizarTestes;
        private GroupBox groupBox1;
    }
}