using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloTeste
{
    public class RepositorioTeste : RepositorioBase<Teste>
    {
        public bool DuplicarRegistro(int id, Teste novaEntidade)
        {
            //Teste registro = SelecionarPorId(id);

            //if (registro == null)
            //    return false;

            Cadastrar(novaEntidade);

            return true;
        }
    }
}