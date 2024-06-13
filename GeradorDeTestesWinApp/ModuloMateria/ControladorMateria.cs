using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private RepositorioMateria repositorioMateria;

        private TabelaMateriaControl tabelaMateria;

        public ControladorMateria(RepositorioMateria repositorio)
        {
            repositorioMateria = repositorio;
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

            DialogResult resultado = telaMateria.ShowDialog();

            // guardas = bloquear momentos em que a aplicação toma um "caminho triste"
            if (resultado != DialogResult.OK)
                return;

            Materia novaMateria = telaMateria.Materia;

            //Metodo para Verificar se nome existe
            bool nomeExiste = VerificaNomeExisente(novaMateria);

            if (nomeExiste)
            {
                repositorioMateria.Cadastrar(novaMateria);
            }
            else
                return;

            CarregarMaterias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaMateria.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm();

            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materia materiaSelecionado =
                repositorioMateria.SelecionarPorId(idSelecionado);

            if (materiaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaMateria.Materia = materiaSelecionado;

            DialogResult resultado = telaMateria.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Materia materiaEditado = telaMateria.Materia;

            //Metodo para Verificar se nome existe
            bool nomeExiste = VerificaNomeExisente(materiaEditado);

            if (nomeExiste)
            {
                repositorioMateria.Editar(materiaSelecionado.Id, materiaEditado);
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

        private bool VerificaNomeExisente(Materia novaMateria)
        {
            List<Materia> materiasCadastradas = repositorioMateria.SelecionarTodos();

            foreach (Materia materias in materiasCadastradas)
            {
                if (materias.Nome == novaMateria.Nome)
                {
                    MessageBox.Show(
                        "Não é possível realizar esta pois já existe uma máteria com este nome",
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
