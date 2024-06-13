using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private RepositorioMateria repositorioMateria;

        private TabelaMateriaControl tabelaMateria;

        public ControladorMateria(RepositorioMateria repositorio)
        {
            repositorioMateria = repositorio;
        }

        #region ToolTips
        public override string TipoCadastro { get { return "Matérias"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova matéria"; } }

        public override string ToolTipEditar { get { return "Editar uma matéria existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma matéria existente"; } }
        #endregion

        public override void Adicionar()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm();

            DialogResult resultado = telaMateria.ShowDialog();

            // guardas = bloquear momentos em que a aplicação toma um "caminho triste"
            if (resultado != DialogResult.OK)
                return;

            Materia novaMateria = telaMateria.Materia;

            repositorioMateria.Cadastrar(novaMateria);

            CarregarMaterias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaMateria.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaMateria == null)
                tabelaMateria = new TabelaMateriaControl();

            CarregarMaterias();

            return tabelaMateria;
        }

        private void CarregarMaterias()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(materias);
        }
    }
}
