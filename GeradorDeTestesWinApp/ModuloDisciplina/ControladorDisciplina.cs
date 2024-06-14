using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloMateria;

namespace GeradorDeTestesWinApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        RepositorioDisciplina repositorioDisciplina;

        public TabelaDisciplinaControl tabelaDisciplina;

        public ControladorDisciplina(RepositorioDisciplina repositorio)
        {
            repositorioDisciplina = repositorio;
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
            bool nomeExiste = VerificaNomeExisente(novaDisciplina);

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

            repositorioDisciplina.Editar(disciplinaSelecionada.Id, disciplinaEditada);
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

        private bool VerificaNomeExisente(Disciplina novaDisciplina)
        {
            List<Disciplina> disciplinasCadastradas = repositorioDisciplina.SelecionarTodos();

            foreach (Disciplina discplinas in disciplinasCadastradas)
            {
                if (discplinas.Nome == novaDisciplina.Nome)
                {
                    MessageBox.Show(
                        "Não é possível realizar esta pois já existe uma Disciplina com este nome",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return false;
                }
            }

            return true;
        }
    }
}