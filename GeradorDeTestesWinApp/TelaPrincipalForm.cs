using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;
using GeradorDeTestesWinApp.ModuloQuestao;
using GeradorDeTestesWinApp.ModuloTeste;

namespace GeradorDeTestesWinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        #region Repositorios
        RepositorioDisciplina repositorioDisciplina;
        RepositorioMateria repositorioMateria;
        RepositorioQuestao repositorioQuestao;
        RepositorioTeste repositorioTeste;
        #endregion

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;

            #region Repositorios
            repositorioDisciplina = new RepositorioDisciplina();
            repositorioMateria = new RepositorioMateria();
            repositorioQuestao = new RepositorioQuestao();
            repositorioTeste = new RepositorioTeste();
            #endregion

            CadastrarRegistrosTeste();
        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        #region Botoes Adicionar, Editar e Excluir
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
        #endregion

        #region Botoes do MenuStrip
        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDisciplina(repositorioDisciplina, repositorioQuestao, repositorioTeste);

            ConfigurarTelaPrincipal(controlador);
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina, repositorioQuestao);

            ConfigurarTelaPrincipal(controlador);
        }

        private void questoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorQuestao(repositorioQuestao, repositorioMateria);

            ConfigurarTelaPrincipal(controlador);
        }

        private void testesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTeste(repositorioTeste, repositorioMateria, repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
        }
        #endregion

        private void btnDuplicarTeste_Click(object sender, EventArgs e)
        {
            ControladorTeste controladorTeste = new ControladorTeste(repositorioTeste, repositorioMateria, repositorioDisciplina);

            ConfigurarTelaPrincipal(controladorTeste);

            controladorTeste.DuplicarTeste();
        }


        #region Configurações
        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            btnDuplicarTeste.Enabled = controladorSelecionado is ControladorTeste;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

            if (controladorSelecionado is ControladorTeste controladorTeste)
                btnDuplicarTeste.ToolTipText = controladorTeste.ToolTipDuplicar;
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagem = controladorSelecionado.ObterListagem();
            listagem.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagem);
        }
        #endregion


        private void CadastrarRegistrosTeste()
        {
            List<Disciplina> disciplinas = new List<Disciplina>()
            {
                new("Matemática"),
                new("Português"),
                new("Quimica"),
                new("Artes"),
                new("História")
            };

            repositorioDisciplina.CadastrarVarios(disciplinas);

            List<Materia> materias = new List<Materia>()
            {
                new("Algebra", disciplinas[0], SerieMateriaEnum.PrimeiraSerie),
                new("Alfabeto", disciplinas[1], SerieMateriaEnum.SegundaSerie)
            };

            repositorioMateria.CadastrarVarios(materias);

            disciplinas[0].AdicionarMaterias(materias[0]);
            disciplinas[1].AdicionarMaterias(materias[1]);

            List<Alternativa> alternativas = new List<Alternativa>()
            {
                new ("teste", false),
                new ("teste2", false),
                new ("test3", false),
                new ("teste4", true)
            };

            List<Questao> questoes = new List<Questao>
            {
                new(materias[0], "teste de questao 1", alternativas),
                new(materias[0], "teste de questao 2", alternativas),
                new(materias[0], "teste de questao 3", alternativas),
                new(materias[0], "teste de questao 4", alternativas),
                new(materias[0], "teste de questao 5", alternativas),
                new(materias[0], "teste de questao 6", alternativas),
                new(materias[0], "teste de questao 7", alternativas),
                new(materias[0], "teste de questao 8", alternativas),
                new(materias[0], "teste de questao 9", alternativas),
                new(materias[0], "teste de questao 10", alternativas),
                new(materias[0], "teste de questao 11", alternativas),
                new(materias[0], "teste de questao 12", alternativas),
                new(materias[0], "teste de questao 13", alternativas),
                new(materias[0], "teste de questao 14", alternativas),
            };

            repositorioQuestao.CadastrarVarios(questoes);

            disciplinas[0].AdicionarQuestao(questoes[0]);
            disciplinas[0].AdicionarQuestao(questoes[1]);
            disciplinas[0].AdicionarQuestao(questoes[2]);
            disciplinas[0].AdicionarQuestao(questoes[3]);
            disciplinas[0].AdicionarQuestao(questoes[4]);
            disciplinas[0].AdicionarQuestao(questoes[5]);
            disciplinas[0].AdicionarQuestao(questoes[6]);
            disciplinas[0].AdicionarQuestao(questoes[7]);
            disciplinas[0].AdicionarQuestao(questoes[8]);
            disciplinas[0].AdicionarQuestao(questoes[9]);
            disciplinas[0].AdicionarQuestao(questoes[10]);
            disciplinas[0].AdicionarQuestao(questoes[11]);
            disciplinas[0].AdicionarQuestao(questoes[12]);
            disciplinas[0].AdicionarQuestao(questoes[13]);
        }
    }
}
