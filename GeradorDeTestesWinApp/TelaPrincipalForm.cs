﻿using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;

namespace GeradorDeTestesWinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        #region Repositorios
        RepositorioDisciplina repositorioDisciplina;
        RepositorioMateria repositorioMateria;
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
            #endregion
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
            controlador = new ControladorDisciplina(repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMateria);

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
    }
}
