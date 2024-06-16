using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloMateria;

namespace GeradorDeTestesWinApp.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private TabelaQuestaoControl tabelaQuestao;

        private RepositorioQuestao repositorioQuestao;
        private RepositorioMateria repositorioMateria;

        public ControladorQuestao(RepositorioQuestao repositorio, RepositorioMateria repositorioMateria)
        {
            repositorioQuestao = repositorio;
            this.repositorioMateria = repositorioMateria;
        }

        public override string TipoCadastro { get { return "Questões"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova questão"; } }

        public override string ToolTipEditar { get { return "Editar uma questão existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma questão existente"; } }

        public override void Adicionar()
        {
            TelaQuestaoForm telaQuestao = new TelaQuestaoForm();

            List<Materia> materiasCadastradas = repositorioMateria.SelecionarTodos();

            telaQuestao.CarregarMaterias(materiasCadastradas);

            DialogResult resultado = telaQuestao.ShowDialog();

            // guardas = bloquear momentos em que a aplicação toma um "caminho triste"
            if (resultado != DialogResult.OK)
                return;

            Questao novaQuestao = telaQuestao.Questao;

            repositorioQuestao.Cadastrar(novaQuestao);

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaQuestao.Id}\" foi criado com sucesso!");
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
            if (tabelaQuestao == null)
                tabelaQuestao = new TabelaQuestaoControl();

            CarregarQuestoes();

            return tabelaQuestao;
        }

        private void CarregarQuestoes()
        {
            List<Questao> questao = repositorioQuestao.SelecionarTodos();

            tabelaQuestao.AtualizarRegistros(questao);
        }
    }
}
