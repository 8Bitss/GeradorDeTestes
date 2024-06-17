namespace GeradorDeTestesWinApp.Compartilhado;

public abstract class ControladorBase
{
    public abstract string TipoCadastro { get; }

    public abstract string ToolTipAdicionar { get; }
    public abstract string ToolTipEditar { get; }
    public abstract string ToolTipExcluir { get; }

    public abstract UserControl ObterListagem();

    public abstract bool VerificaEntidadeDuplicada(EntidadeBase entidade, int idSelecionado = 0);

    public abstract void Adicionar();
    public abstract void Editar();
    public abstract void Excluir();
}
