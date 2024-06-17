
using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloQuestao
{
    public class RepositorioQuestaoEmArquivo : RepositorioBaseEmArquivo<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoEmArquivo() : base("questoes.json")
        {
            
        }
    }
}
