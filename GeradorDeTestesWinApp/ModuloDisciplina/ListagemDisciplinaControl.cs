using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloDisciplina
{
    public partial class ListagemDisciplinaControl : UserControl
    {
        public ListagemDisciplinaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            listDisciplina.Items.Clear();
            foreach (Disciplina disciplina in disciplinas)
                listDisciplina.Items.Add(disciplina);
        }
         
        public Disciplina ObterRegistroSelecionado()
        {
            if (listDisciplina.SelectedItems == null)
                return null;

            return (Disciplina)listDisciplina.SelectedItems;
        }
        
    }
}
