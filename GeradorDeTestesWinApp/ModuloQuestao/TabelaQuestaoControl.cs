using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloQuestao
{
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Questao> questoes)
        {
            grid.Rows.Clear();

            foreach (Questao questao in questoes)
                grid.Rows.Add(questao.Id, questao.Materia, questao.Enunciado, questao.RespostasCorretas());
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Matéria" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Alternativas", HeaderText = "Alternativas Corretas" }
            };
        }
    }
}
