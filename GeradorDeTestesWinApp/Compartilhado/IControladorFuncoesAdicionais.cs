namespace GeradorDeTestesWinApp.Compartilhado
{
    public interface IControladorFuncoesAdicionais
    {

        public string ToolTipDuplicar { get; }

        public string ToolTipVisualizarDetalhes { get; }

        void DuplicarTeste();

        void VisualizarDetalhesTeste();
    }
}
