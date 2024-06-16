using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;
using GeradorDeTestesWinApp.ModuloQuestao;

namespace GeradorDeTestesWinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        #region Repositorios
        RepositorioDisciplina repositorioDisciplina;
        RepositorioMateria repositorioMateria;
        RepositorioQuestao repositorioQuestao;
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
            controlador = new ControladorDisciplina(repositorioDisciplina, repositorioQuestao);

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
        #endregion


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

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;
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
        }
    }
}
