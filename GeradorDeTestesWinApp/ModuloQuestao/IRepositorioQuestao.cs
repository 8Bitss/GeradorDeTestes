using GeradorDeTestesWinApp.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestesWinApp.ModuloQuestao
{
    public interface IRepositorioQuestao
    {
        void Cadastrar(Questao novaQuestao);
        //void CadastrarVarios(List<Questao> disciplinas);
        bool Editar(int id, Questao questaoEditada);
        bool Excluir(int id);
        Questao SelecionarPorId(int idSelecionado);
        List<Questao> SelecionarTodos();
    }
}

