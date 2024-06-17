using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;
using GeradorDeTestesWinApp.ModuloQuestao;

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

            List<Questao> questoesAleatorias = new List<Questao>();

            foreach (Questao questao in listQuestoes.Items)
            {
                questoesAleatorias.Add(questao);
            }

            teste = new Teste(titulo, disciplina, materia, qtdQuestoes, questoesAleatorias);

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

            if (txtQtdQuestoes.Value != 0)
                btnSortearQuestoes.Enabled = true;

            Disciplina disciplinaSelecionada = DisciplinaSelecionada();

            foreach (Materia materiasDisciplina in disciplinaSelecionada.Materias)
            {
                cmbMaterias.Items.Add(materiasDisciplina);
            }

            cmbMaterias.Items.ToString();

        }

        private void btnSortearQuestoes_Click(object sender, EventArgs e)
        {
            listQuestoes.Items.Clear();

            Random rand = new Random();

            Disciplina disciplina = DisciplinaSelecionada();
            
            int contador = 0;
            int indiceAleatorio = 0;

            if (txtQtdQuestoes.Value > disciplina.Questoes.Count)
            {
                MessageBox.Show
                    (
                        "A quantidade de Questões precisa ser menor ou igual a quantidade registrada.",
                        "aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
            }
            else
            {
                foreach (Questao questao in disciplina.Questoes)
                {
                    indiceAleatorio = rand.Next(0, disciplina.Questoes.Count);

                    if (contador < txtQtdQuestoes.Value)
                    {
                        listQuestoes.Items.Add(disciplina.Questoes[indiceAleatorio]);
                        contador++;
                    }
                    else
                        return;
                }
            }
        }

        private void txtQtdQuestoes_ValueChanged(object sender, EventArgs e)
        {
            if (txtQtdQuestoes.Value == 0)
                btnSortearQuestoes.Enabled = false;

            else if (txtQtdQuestoes.Value != 0 && cmbDisciplinas.SelectedItem != null)
                btnSortearQuestoes.Enabled = true;
        }
    }
}