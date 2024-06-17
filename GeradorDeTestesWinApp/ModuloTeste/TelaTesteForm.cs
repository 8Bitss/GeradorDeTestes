using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;

namespace GeradorDeTestesWinApp.ModuloTeste
{
    public partial class TelaTesteForm : Form
    {
        private RepositorioMateria repositorioMateria;

        private Teste teste { get; set; }

        public Teste Teste
        {
            get { return teste; }

            set
            {
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo;
                cmbDisciplinas.SelectedItem = value.Disciplina;
                cmbMaterias.SelectedItem = value.Materia;
                txtQtdQuestoes.Value = value.QtdQuestoes;
            }
        }

        public TelaTesteForm(RepositorioMateria repositorioMateria)
        {
            InitializeComponent();
            this.repositorioMateria = repositorioMateria;
        }

        //public void CarregarMaterias(Disciplina disciplinaSelecionada)
        //{
        //    cmbMaterias.Items.Clear();

        //    foreach (Materia m in disciplinaSelecionada.Materias)
        //        cmbMaterias.Items.Add(m);
        //}

        //public Disciplina DisciplinaSelecionada()
        //{
        //    Disciplina disciplinaSelecionada = (Disciplina)cmbDisciplinas.SelectedItem;

        //    return disciplinaSelecionada;
        //}

        public void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cmbDisciplinas.Items.Clear();

            foreach (Disciplina d in disciplinas)
                cmbDisciplinas.Items.Add(d);
        }

        public void CarregarMaterias(List<Materia> materias)
        {
            cmbMaterias.Items.Clear();

            foreach (Materia m in materias)
                cmbMaterias.Items.Add(m);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            Disciplina disciplina = cmbDisciplinas.SelectedItem as Disciplina;
            Materia materia = cmbMaterias.SelectedItem as Materia;

            int qtdQuestoes = (int)txtQtdQuestoes.Value;

            teste = new Teste(titulo, disciplina, materia, qtdQuestoes);

            List<string> erros = teste.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

    }
}