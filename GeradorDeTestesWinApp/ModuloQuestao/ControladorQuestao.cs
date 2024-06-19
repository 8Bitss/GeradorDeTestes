using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;
using GeradorDeTestesWinApp.ModuloTeste;

namespace GeradorDeTestesWinApp.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private TabelaQuestaoControl tabelaQuestao;

        private IRepositorioQuestao repositorioQuestao;
        private IRepositorioMateria repositorioMateria;

        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioTeste repositorioTeste;

        public ControladorQuestao(IRepositorioQuestao repositorio, IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina, IRepositorioTeste repositorioTeste)
        {
            repositorioQuestao = repositorio;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioTeste = repositorioTeste;
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

            bool enunciadoExiste = VerificaEntidadeDuplicada(novaQuestao);

            if (enunciadoExiste)
            {
                repositorioQuestao.Cadastrar(novaQuestao);
            }
            else
                return;

            repositorioDisciplina.AdicionarNaLista(novaQuestao.Materia.Disciplina.Questoes, novaQuestao);
            

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaQuestao.Id}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaQuestaoForm telaQuestao = new TelaQuestaoForm();

            List<Materia> materiasCadastradas = repositorioMateria.SelecionarTodos();

            telaQuestao.CarregarMaterias(materiasCadastradas);

            int idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            Questao questaoSelecionada =
                repositorioQuestao.SelecionarPorId(idSelecionado);

            if (questaoSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaQuestao.Questao = questaoSelecionada;

            DialogResult resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Questao questaoEditada = telaQuestao.Questao;

            //Metodo para Verificar se enunciado existe
            bool enunciadoExiste = VerificaEntidadeDuplicada(questaoEditada,idSelecionado);

            if (enunciadoExiste)
            {
                repositorioQuestao.Editar(questaoSelecionada.Id, questaoEditada);
            }
            else
                return;

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro { questaoEditada.Enunciado} foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaQuestao.ObterRegistroSelecionado();
            Questao questaoSelecionada =
            repositorioQuestao.SelecionarPorId(idSelecionado);

            if (questaoSelecionada == null)
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
            $"Você deseja realmente excluir o registro \"{questaoSelecionada.Enunciado}\"?",
            "Confirmar Exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );


            List<Teste> testesCadastrados = repositorioTeste.SelecionarTodos();
            int i = 0;
            foreach (Teste teste in testesCadastrados)
            {
                if (questaoSelecionada.Enunciado == teste.Disciplina.Questoes[i].Enunciado)
                {
                    MessageBox.Show(
                        "Não é possível realizar esta ação pois o registro selecionado é usado em Testes.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
                i++;
            }

            if (resposta != DialogResult.Yes)
                return;

            repositorioQuestao.Excluir(questaoSelecionada.Id);

            CarregarQuestoes();

            TelaPrincipalForm
            .Instancia
            .AtualizarRodape($"O registro \"{questaoSelecionada.Enunciado}\" foi excluído com sucesso!");
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


        public override bool VerificaEntidadeDuplicada(EntidadeBase entidade, int idSelecionado = 0)
        {
            Questao novaQuestao = (Questao)entidade;

            List<Questao> questoesCadastradas = repositorioQuestao.SelecionarTodos();

            foreach (Questao questao in questoesCadastradas)
            {
                if (idSelecionado == 0)
                {
                    if (questao.Enunciado.ToUpper() == novaQuestao.Enunciado.ToUpper())
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
                else
                {
                    if (questao.Enunciado.ToUpper() == novaQuestao.Enunciado.ToUpper() && questao.Id != idSelecionado)
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
