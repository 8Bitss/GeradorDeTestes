using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloQuestao;

namespace GeradorDeTestesWinApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private RepositorioMateria repositorioMateria;
        private RepositorioDisciplina repositorioDisciplina;
        private RepositorioQuestao repositorioQuestao;

        private TabelaMateriaControl tabelaMateria;

        public ControladorMateria(RepositorioMateria repositorio, RepositorioDisciplina repositorioDisciplina, RepositorioQuestao repositorioQuestao)
        {
            repositorioMateria = repositorio;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioQuestao = repositorioQuestao;
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

            List<Disciplina> disciplinasCadastradas = repositorioDisciplina.SelecionarTodos();

            telaMateria.CarregarDisciplinas(disciplinasCadastradas);

            DialogResult resultado = telaMateria.ShowDialog();

            // guardas = bloquear momentos em que a aplicação toma um "caminho triste"
            if (resultado != DialogResult.OK)
                return;

            Materia novaMateria = telaMateria.Materia;

            //Metodo para Verificar se nome existe
            bool nomeExiste = VerificaNomeExistente(novaMateria);

            if (nomeExiste)
                repositorioMateria.Cadastrar(novaMateria);
            else
                return;

            novaMateria.Disciplina.AdicionarMaterias(novaMateria);

            CarregarMaterias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaMateria.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm();

            List<Disciplina> disciplinasCadastradas = repositorioDisciplina.SelecionarTodos();

            telaMateria.CarregarDisciplinas(disciplinasCadastradas);

            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materia materiaSelecionada =
                repositorioMateria.SelecionarPorId(idSelecionado);

            if (materiaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaMateria.Materia = materiaSelecionada;

            DialogResult resultado = telaMateria.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Materia materiaEditado = telaMateria.Materia;

            //Metodo para Verificar se nome existe
            bool nomeExiste = VerificaNomeExistente(materiaEditado, idSelecionado);

            if (nomeExiste)
            {
                repositorioMateria.Editar(materiaSelecionada.Id, materiaEditado);
            }
            else
                return;

            CarregarMaterias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{materiaEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materia materiaSelecionada =
                repositorioMateria.SelecionarPorId(idSelecionado);

            if (materiaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{materiaSelecionada.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            List<Questao> questoesCadastradas = repositorioQuestao.SelecionarTodos();

            foreach (Questao questao in questoesCadastradas)
            {
                if (materiaSelecionada.Nome == questao.Materia.Nome)
                {
                    MessageBox.Show(
                        "Não é possível realizar esta ação pois o registro selecionado é usado em questões.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
            }

            if (resposta != DialogResult.Yes)
                return;

            repositorioMateria.Excluir(materiaSelecionada.Id);

            CarregarMaterias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{materiaSelecionada.Nome}\" foi excluído com sucesso!");
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

        private bool VerificaNomeExistente(Materia novaMateria, int idSelecionado = 0)
        {
            List<Materia> materiasCadastradas = repositorioMateria.SelecionarTodos();

            foreach (Materia materias in materiasCadastradas)
            {
                if (idSelecionado == 0)
                {
                    if (materias.Nome.ToUpper() == novaMateria.Nome.ToUpper())
                    {
                        MessageBox.Show(
                            "Não é possível realizar esta pois já existe uma materia com este nome",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return false;
                    }
                }
                else
                {
                    if (materias.Nome.ToUpper() == novaMateria.Nome.ToUpper() && materias.Id != idSelecionado)
                    {
                        MessageBox.Show(
                            "Não é possível realizar esta pois já existe uma questao com este nome",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
