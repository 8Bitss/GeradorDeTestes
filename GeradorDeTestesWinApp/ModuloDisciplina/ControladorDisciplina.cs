﻿using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        RepositorioDisciplina repositorioDisciplina;

        public TabelaDisciplinaControl tabelaDisciplina;
        
        public override string TipoCadastro { get { return "Disciplinas"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova disciplina"; } }

        public override string ToolTipEditar { get { return "Editar uma disciplina existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma disciplina existente"; } }


        public ControladorDisciplina(RepositorioDisciplina repositorio)
        {
            repositorioDisciplina = repositorio;
        }

        public override void Adicionar()
        {
            TelaDisciplinaForm telaDisciplinaForm = new TelaDisciplinaForm();

            DialogResult resultado = telaDisciplinaForm.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina novoDisciplina = telaDisciplinaForm.Disciplina;

            repositorioDisciplina.Cadastrar(novoDisciplina);
            CarregarDisciplina();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape(($"O registro \"{novoDisciplina.Nome}\" foi criado com sucesso!"));
        }

        private void CarregarDisciplina()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {

            TelaDisciplinaForm teladisciplina = new TelaDisciplinaForm();

            int idSelecionado = teladisciplina.ObterRegistroSelecionado();

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

            teladisciplina.Disciplina = disciplinaSelecionada;

            DialogResult resultado = teladisciplina.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina disciplinaEditada = teladisciplina.Disciplina;

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

        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            tabelaDisciplina.AtualizarRegistros(disciplinas);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDisciplina == null)
                tabelaDisciplina = new TabelaDisciplinaControl();

            CarregarDisciplinas();

            return tabelaDisciplina;

        }
    }
}