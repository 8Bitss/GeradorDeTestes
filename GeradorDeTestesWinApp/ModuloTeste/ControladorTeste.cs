using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;
using GeradorDeTestesWinApp.ModuloQuestao;

namespace GeradorDeTestesWinApp.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private TabelaTesteControl tabelaTeste;

        private RepositorioTeste repositorioTeste;
        private RepositorioMateria repositorioMateria;
        private RepositorioDisciplina repositorioDisciplina;

        public ControladorTeste(RepositorioTeste repositorio, RepositorioMateria repositorioMateria, RepositorioDisciplina repositorioDisciplina)
        {
            repositorioTeste = repositorio;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override string TipoCadastro { get { return "Testes"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo teste"; } }

        public override string ToolTipEditar { get { return "Editar um teste existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma teste existente"; } }


        public override void Adicionar()
        {
            TelaTesteForm telaTeste = new TelaTesteForm(repositorioMateria);

            List<Disciplina> disciplinasCadastradas = repositorioDisciplina.SelecionarTodos();
            telaTeste.CarregarDisciplinas(disciplinasCadastradas);

            List<Materia> materiasCadastradas = repositorioMateria.SelecionarTodos();
            telaTeste.CarregarMaterias(materiasCadastradas);

            DialogResult resultado = telaTeste.ShowDialog();

            // guardas = bloquear momentos em que a aplicação toma um "caminho triste"
            if (resultado != DialogResult.OK)
                return;

            Teste novoTeste = telaTeste.Teste;

            //Metodo para Verificar se nome existe
            bool nomeExiste = VerificaEntidadeDuplicada(novoTeste);

            if (nomeExiste)
                repositorioTeste.Cadastrar(novoTeste);
            else
                return;

            CarregarTestes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoTeste.Titulo}\" foi criado com sucesso!");
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
            if (tabelaTeste == null)
                tabelaTeste = new TabelaTesteControl();

            CarregarTestes();

            return tabelaTeste;
        }

        public override bool VerificaEntidadeDuplicada(EntidadeBase entidade, int idSelecionado = 0)
        {
            Teste novoTeste = (Teste)entidade;

            List<Teste> testesCadastrados = repositorioTeste.SelecionarTodos();

            foreach (Teste teste in testesCadastrados)
            {
                if (idSelecionado == 0)
                {
                    if (teste.Titulo.ToUpper() == novoTeste.Titulo.ToUpper())
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
                    if (teste.Titulo.ToUpper() == novoTeste.Titulo.ToUpper() && teste.Id != idSelecionado)
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

        private void CarregarTestes()
        {
            List<Teste> teste = repositorioTeste.SelecionarTodos();

            tabelaTeste.AtualizarRegistros(teste);

        }
    }
}
