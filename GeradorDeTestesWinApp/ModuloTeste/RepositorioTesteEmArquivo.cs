using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloTeste
{
    public class RepositorioTesteEmArquivo : RepositorioBaseEmArquivo<Teste>, IRepositorioTeste
    {
        public RepositorioTesteEmArquivo() : base("testes.json")
        {
            
        }
    }
}
