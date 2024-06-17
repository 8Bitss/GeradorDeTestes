using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestesWinApp.ModuloDisciplina
{
    public interface IRepositorioDisciplina
    {
        void Cadastrar(Disciplina novaDisciplina);
        //void CadastrarVarios(List<Disciplina> disciplinas);
        bool Editar(int id, Disciplina disciplinaEditada);
        bool Excluir(int id);
        Disciplina SelecionarPorId(int idSelecionado);
        List<Disciplina> SelecionarTodos();
    }
}
