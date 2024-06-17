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
        IRepositorioDisciplina repositorioDisciplina;
        IRepositorioMateria repositorioMateria;
        IRepositorioQuestao repositorioQuestao;
        IRepositorioTeste repositorioTeste;
        #endregion

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;

            #region Repositorios
            repositorioDisciplina = new RepositorioDisciplinaEmArquivo();
            repositorioMateria = new RepositorioMateriaEmArquivo();
            repositorioQuestao = new RepositorioQuestaoEmArquivo();
            repositorioTeste = new RepositorioTesteEmArquivo();
            #endregion

            //CadastrarRegistrosTeste();
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
    }
}
