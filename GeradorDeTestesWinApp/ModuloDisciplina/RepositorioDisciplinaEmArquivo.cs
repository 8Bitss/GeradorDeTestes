using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloMateria;
using GeradorDeTestesWinApp.ModuloTeste;

namespace GeradorDeTestesWinApp.ModuloDisciplina
{
    public class RepositorioDisciplinaEmArquivo : RepositorioBaseEmArquivo<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if(contexto.Disciplinas.Any())
                contadorId = contexto.Disciplinas.Max(d => d.Id) + 1;
        }

        protected override List<Disciplina> ObterRegistros()
        {
            return contexto.Disciplinas;
        }

        public override bool Excluir(int id)
        {
            Disciplina disciplina = SelecionarPorId(id);

            List<Materia> materiasRelacionadas =
                contexto.Materias.FindAll(m => m.Disciplina.Id == disciplina.Id);

            foreach (Materia m in materiasRelacionadas)
                m.Disciplina = null;

            List<Teste> testesRelacionados =
                contexto.Testes.FindAll(t => t.Disciplina.Id == disciplina.Id);
            
            foreach (Teste t in testesRelacionados)
                t.Disciplina = null;


            return base.Excluir(id);
        }
        
    }
}
