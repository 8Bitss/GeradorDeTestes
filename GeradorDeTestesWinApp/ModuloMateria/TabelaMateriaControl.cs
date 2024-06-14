using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloMateria
{
    public partial class TabelaMateriaControl : UserControl
    {
        public TabelaMateriaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Materia> materias)
        {
            grid.Rows.Clear();

            foreach (Materia materia in materias)
                grid.Rows.Add(materia.Id, materia.Nome, materia.Disciplina.Nome, materia.SerieMateria);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Serie", HeaderText = "Série" }
            };
        }
    }
}
