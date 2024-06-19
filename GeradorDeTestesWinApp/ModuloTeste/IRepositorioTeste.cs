namespace GeradorDeTestesWinApp.ModuloTeste
{
    public interface IRepositorioTeste
    {
        void Cadastrar(Teste novaTeste);
        bool Editar(int id, Teste testeEditado);
        bool Excluir(int id);
        Teste SelecionarPorId(int idSelecionado);
        List<Teste> SelecionarTodos();


        public bool DuplicarRegistro(int id, Teste novaEntidade)
        {
            Cadastrar(novaEntidade);

            return true;
        }
    }
}
