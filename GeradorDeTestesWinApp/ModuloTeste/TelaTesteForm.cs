using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;

namespace GeradorDeTestesWinApp.ModuloTeste
{
    public partial class TelaTesteForm : Form
    {
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

        public TelaTesteForm()
        {
            InitializeComponent();
        }
        
        public void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cmbDisciplinas.Items.Clear();

            foreach (Disciplina d in disciplinas)
                cmbDisciplinas.Items.Add(d);
        }

        public Disciplina DisciplinaSelecionada()
        {
            Disciplina disciplinaSelecionada = (Disciplina)cmbDisciplinas.SelectedItem;

            return disciplinaSelecionada;
        }

        public Materia MateriaSelecionada()
        {
            Materia materiaSelecionada = (Materia)cmbMaterias.SelectedItem;

            return materiaSelecionada;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            Disciplina disciplina = DisciplinaSelecionada();
            Materia materia = MateriaSelecionada();

            int qtdQuestoes = (int)txtQtdQuestoes.Value;

            teste = new Teste(titulo, disciplina, materia, qtdQuestoes);

            List<string> erros = teste.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void cmbDisciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMaterias.Items.Clear();

            cmbMaterias.Enabled = true;

            Disciplina disciplinaSelecionada = DisciplinaSelecionada();

            foreach(Materia materiasDisciplina in disciplinaSelecionada.Materias)
            {
                cmbMaterias.Items.Add(materiasDisciplina);
            }

            cmbMaterias.Items.ToString();

        }
    }
}