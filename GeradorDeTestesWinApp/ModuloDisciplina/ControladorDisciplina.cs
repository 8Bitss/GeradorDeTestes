using GeradorDeTestesWinApp.ModuloCompartilhado;

namespace GeradorDeTestesWinApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        RepositorioDisciplina repositorioDisciplina;

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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }


    }
}
