using GeradorDeTestesWinApp.ModuloQuestao;

namespace GeradorDeTestesWinApp.ModuloTeste
{
    public partial class TelaTesteDetalhadoForm : Form
    {
        private Teste teste { get; set; }

        public Teste Teste
        {
            get
            {
                return teste;
            }
            set
            {
                teste = value;
            }
        }

        public TelaTesteDetalhadoForm(Teste testeSelecionado)
        {
            InitializeComponent();

            Teste = testeSelecionado;

            lblTituloSelecionado.Text = testeSelecionado.Titulo;

            lblDisciplinaSelecionada.Text = testeSelecionado.Disciplina.Nome;

            if(testeSelecionado.Materia == null)
                lblMateriaSelecionada.Text = "Geral";
            else
                lblMateriaSelecionada.Text = testeSelecionado.Materia.Nome;

            foreach (Questao questao in testeSelecionado.QuestoesSelecionadas)
            {
                listQuestoesSelecionadas.Items.Add(questao);
            }
        }
    }
}
