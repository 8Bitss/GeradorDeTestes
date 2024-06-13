using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();

            dataGridViewDisciplina.Columns.AddRange(ObterColunas());

            dataGridViewDisciplina.ConfigurarGridSomenteLeitura();
            dataGridViewDisciplina.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            dataGridViewDisciplina.Rows.Clear();

            foreach (Disciplina d in disciplinas)
                dataGridViewDisciplina.Rows.Add(d.Nome);
        }

        public int ObterRegistroSelecionado()
        {
            return dataGridViewDisciplina.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
             };
        }
    }
}
