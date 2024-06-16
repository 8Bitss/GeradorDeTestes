//using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestesWinApp.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private Materia materia { get; set; }

        public Materia Materia
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;

                cmbDisciplinas.SelectedItem = value.Disciplina;
            }
            get
            {
                return materia;
            }
        }

        public TelaMateriaForm()
        {
            InitializeComponent();
        }

        public void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cmbDisciplinas.Items.Clear();

            foreach (Disciplina d in disciplinas)
                cmbDisciplinas.Items.Add(d);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            Disciplina disciplinaSelecionada = cmbDisciplinas.SelectedItem as Disciplina;
            SerieMateriaEnum serie;

            if (!rdb1Serie.Checked && !rdb2Serie.Checked)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma serie selecionada",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

                serie = 0;
            }

            else if (rdb1Serie.Checked)
                serie = SerieMateriaEnum.PrimeiraSerie;
            else
                serie = SerieMateriaEnum.SegundaSerie;

            materia = new Materia(nome, disciplinaSelecionada, serie);

            List<string> erros = materia.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

        }
    }
}
