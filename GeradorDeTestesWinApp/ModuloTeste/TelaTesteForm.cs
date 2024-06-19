using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;
using GeradorDeTestesWinApp.ModuloQuestao;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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

            RecuperacaoEnum recuperacao = RecuperacaoEnum.Nao;

            if (checkRecuperacao.Checked)
                recuperacao = RecuperacaoEnum.Sim;

            List<Questao> questoesAleatorias = new List<Questao>();

            foreach (Questao questao in listQuestoes.Items)
            {
                questoesAleatorias.Add(questao);
            }

            teste = new Teste(titulo, disciplina, materia, qtdQuestoes, questoesAleatorias, recuperacao);

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
            listQuestoes.Items.Clear();

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

            List<Questao> questoesMateria = disciplina.Questoes;

            List<Questao> questoesFiltradas = new List<Questao>();
            
            if(checkRecuperacao.Checked)
            {
                questoesFiltradas = questoesMateria;
            }
            else
                questoesFiltradas = FiltrarQuestoesMateria(disciplina, MateriaSelecionada());

            int indiceAleatorio = 0;
            int i = 0;
            List<int> indicesUsados = new List<int>();

            if (txtQtdQuestoes.Value > questoesFiltradas.Count)
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
                List<Questao> questoesAdicionadas = new List<Questao>();

                foreach (Questao questao in questoesFiltradas)
                {
                    indiceAleatorio = rand.Next(0, questoesFiltradas.Count);

                    if (questoesFiltradas.Count == txtQtdQuestoes.Value)
                    {
                        listQuestoes.Items.Add(questao);
                    }
                    else if (questoesAdicionadas.Count < txtQtdQuestoes.Value)
                    {
                        foreach (Questao questaoAtual in questoesFiltradas)
                        {
                            if (questoesAdicionadas.Count == 0)
                            {
                                listQuestoes.Items.Add(questoesFiltradas[indiceAleatorio]);
                                questoesAdicionadas.Add(questoesFiltradas[indiceAleatorio]);
                                indicesUsados.Add(indiceAleatorio);
                                continue;
                            }
                            else if (questoesAdicionadas.Count > 0 && questoesAdicionadas.Count < txtQtdQuestoes.Value)
                            {
                                if (indiceAleatorio == indicesUsados[i])
                                {
                                    break;
                                }
                                else
                                {
                                    listQuestoes.Items.Add(questoesFiltradas[indiceAleatorio]);
                                    questoesAdicionadas.Add(questoesFiltradas[indiceAleatorio]);
                                    indicesUsados.Add(indiceAleatorio);
                                }
                            }
                            i++;
                        }

                    }
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

        public List<Questao> FiltrarQuestoesMateria(Disciplina disciplina, Materia materia)
        {
            List<Questao> questoesFiltradas = new List<Questao>();

            List<Questao> questoesMateria = disciplina.Questoes;

            Materia materiaSelecionada = MateriaSelecionada();

            foreach (Questao questao in questoesMateria)
            {
                if (questao.Materia == materiaSelecionada)
                {
                    questoesFiltradas.Add(questao);
                }
            }

            return questoesFiltradas;

        }

        private void checkRecuperacao_CheckedChanged(object sender, EventArgs e)
        {
            if(checkRecuperacao.Checked)
            {
                cmbMaterias.Enabled = false;
            }
        }
    }
}