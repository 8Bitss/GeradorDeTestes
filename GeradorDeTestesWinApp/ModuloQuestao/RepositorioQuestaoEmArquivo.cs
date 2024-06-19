
using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;

namespace GeradorDeTestesWinApp.ModuloQuestao
{
    public class RepositorioQuestaoEmArquivo : RepositorioBaseEmArquivo<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Questoes.Any())
                contadorId = contexto.Questoes.Max(q => q.Id) + 1;
        }

        protected override List<Questao> ObterRegistros()
        {
            return contexto.Questoes;
        }


        public override bool Excluir(int id)
        {
            Questao questao = SelecionarPorId(id);

            List<Materia> materiasRelacionadas =
                contexto.Materias.FindAll(d => d == questao.Materia);

            foreach (Materia m in materiasRelacionadas)
                m.Disciplina.Questoes.Remove(questao);

            return base.Excluir(id);
        }
    }
}
