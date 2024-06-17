using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloTeste
{
    public class RepositorioTesteEmMemoria : RepositorioBaseEmMemoria<Teste>
    {
        public bool DuplicarRegistro(int id, Teste novaEntidade)
        {
            Cadastrar(novaEntidade);

            return true;
        }
    }
}