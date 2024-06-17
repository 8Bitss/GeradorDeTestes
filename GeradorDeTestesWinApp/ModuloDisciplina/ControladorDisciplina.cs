using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloMateria;
using GeradorDeTestesWinApp.ModuloQuestao;
using GeradorDeTestesWinApp.ModuloTeste;
using System.Runtime.CompilerServices;

namespace GeradorDeTestesWinApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private RepositorioDisciplina repositorioDisciplina;
        private RepositorioQuestao repositorioQuestao;
        private RepositorioTeste repositorioTeste;

        public TabelaDisciplinaControl tabelaDisciplina;

        public ControladorDisciplina(RepositorioDisciplina repositorio, RepositorioQuestao repositorioQuestao, RepositorioTeste repositorioTeste)
        {
            repositorioDisciplina = repositorio;
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioTeste = repositorioTeste;
            PegarQuestoes();
        }

        public override string TipoCadastro { get { return "Disciplinas"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova disciplina"; } }

        public override string ToolTipEditar { get { return "Editar uma disciplina existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma disciplina existente"; } }


        public override void Adicionar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm();

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina novaDisciplina = telaDisciplina.Disciplina;

            //Metodo para Verificar se nome existe
            bool nomeExiste = VerificaEntidadeDuplicada(novaDisciplina);

            if (nomeExiste)
                repositorioDisciplina.Cadastrar(novaDisciplina);
            else
                return;

            CarregarDisciplinas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape(($"O registro \"{novaDisciplina.Nome}\" foi criado com sucesso!"));
        }


        public override void Editar()
        {

            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm();

            int idSelecionado = tabelaDisciplina.ObterRegistroSelecionado();

            Disciplina disciplinaSelecionada =
                repositorioDisciplina.SelecionarPorId(idSelecionado);

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaDisciplina.Disciplina = disciplinaSelecionada;

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina disciplinaEditada = telaDisciplina.Disciplina;

            //Metodo para Verificar se nome existe
            bool nomeExiste = VerificaEntidadeDuplicada(disciplinaEditada, idSelecionado);

            if (nomeExiste)
                repositorioDisciplina.Editar(disciplinaSelecionada.Id, disciplinaEditada);
            else
                return;

            CarregarDisciplinas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{disciplinaEditada.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaDisciplina.ObterRegistroSelecionado();

            Disciplina disciplinaSelecionada =
                repositorioDisciplina.SelecionarPorId(idSelecionado);

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                  );
                return;
            }

            if (disciplinaSelecionada.Materias.Count > 0)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação pois o registro possui vínculo com uma matéria",
                    "Aviso",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                  );

                return;
            }

            List<Teste> testesCadastrados = repositorioTeste.SelecionarTodos();

            foreach (Teste teste in testesCadastrados)
            {
                if (disciplinaSelecionada.Nome == teste.Disciplina.Nome)
                {
                    MessageBox.Show(
                        "Não é possível realizar esta ação pois o registro possui vínculo com um teste",
                        "Aviso",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
                      );
                    return;
                }
            }

            DialogResult resposta = MessageBox.Show(
               $"Você deseja realmente excluir o registro \"{disciplinaSelecionada.Nome}\"?",
                "Confirmar Exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
             );


            if (resposta != DialogResult.Yes)
                return;

            repositorioDisciplina.Excluir(disciplinaSelecionada.Id);

            CarregarDisciplinas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{disciplinaSelecionada.Nome}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDisciplina == null)
                tabelaDisciplina = new TabelaDisciplinaControl();

            CarregarDisciplinas();

            return tabelaDisciplina;

        }

        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            tabelaDisciplina.AtualizarRegistros(disciplinas);
        }

        public override bool VerificaEntidadeDuplicada(EntidadeBase entidade, int idSelecionado = 0)
        {
            Disciplina novaDisciplina = (Disciplina)entidade;

            List<Disciplina> disciplinasCadastradas = repositorioDisciplina.SelecionarTodos();

            foreach (Disciplina disciplina in disciplinasCadastradas)
            {
                if (idSelecionado == 0)
                {
                    if (disciplina.Nome.ToUpper() == novaDisciplina.Nome.ToUpper())
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
                    if (disciplina.Nome.ToUpper() == novaDisciplina.Nome.ToUpper() && disciplina.Id != idSelecionado)
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

        private void PegarQuestoes()
        {
            var idSelecionado = 1;

            Disciplina dis = repositorioDisciplina.SelecionarPorId(idSelecionado);

            var e = dis.PegarQuestoes(this.repositorioQuestao);

            Console.WriteLine( e );
        }
    }
}