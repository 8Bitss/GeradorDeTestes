using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;

namespace GeradorDeTestesWinApp.ModuloTeste
{
    public class RepositorioTesteEmArquivo : RepositorioBaseEmArquivo<Teste>, IRepositorioTeste
    {
        public RepositorioTesteEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Testes.Any())
                contadorId = contexto.Testes.Max(t => t.Id) + 1;
        }

        protected override List<Teste> ObterRegistros()
        {
            return contexto.Testes;
        }
    }
}
