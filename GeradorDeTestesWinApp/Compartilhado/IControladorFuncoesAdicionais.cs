using GeradorDeTestesWinApp.ModuloTeste;

namespace GeradorDeTestesWinApp.Compartilhado
{
    public interface IControladorFuncoesAdicionais
    {

        public string ToolTipDuplicar { get; }

        public string ToolTipVisualizarDetalhes { get; }

        public string ToolTipGerarPdf { get; }
        
        public string ToolTipGerarGabarito { get; }

        void DuplicarTeste();

        void VisualizarDetalhesTeste();

        void GerarPdfTeste();

        void GerarGabaritoTeste();
    }
}
