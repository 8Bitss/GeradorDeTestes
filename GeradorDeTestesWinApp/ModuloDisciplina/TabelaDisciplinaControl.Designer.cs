namespace GeradorDeTestesWinApp.ModuloDisciplina
{
    partial class TabelaDisciplinaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewDisciplina = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDisciplina).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDisciplina
            // 
            dataGridViewDisciplina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDisciplina.Location = new Point(0, 0);
            dataGridViewDisciplina.Name = "dataGridViewDisciplina";
            dataGridViewDisciplina.RowHeadersWidth = 51;
            dataGridViewDisciplina.Size = new Size(514, 347);
            dataGridViewDisciplina.TabIndex = 0;
            dataGridViewDisciplina.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DisciplinaUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewDisciplina);
            Name = "DisciplinaUserControl";
            Size = new Size(517, 350);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDisciplina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDisciplina;
    }
}
