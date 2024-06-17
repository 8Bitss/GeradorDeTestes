using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloDisciplina
{
    public class RepositorioDisciplinaEmArquivo : RepositorioBaseEmArquivo<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaEmArquivo() : base("disciplinas.json")
        {
            
        }
    }
}
