using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloQuestao;
using GeradorDeTestesWinApp.ModuloTeste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestesWinApp.ModuloMateria
{
    public class RepositorioMateriaEmArquivo : RepositorioBaseEmArquivo<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Materias.Any())
                contadorId = contexto.Materias.Max(m => m.Id) + 1;
        }

        protected override List<Materia> ObterRegistros()
        {
            return contexto.Materias;
        }

        public override bool Excluir(int id)
        {
            Materia materia = SelecionarPorId(id);

            List<Disciplina> disciplinasRelacionadas =
                contexto.Disciplinas.FindAll(d => d.Id == materia.Disciplina.Id);

            foreach (Disciplina d in disciplinasRelacionadas)
                d.Materias.Remove(materia);

            List<Teste> testesRelacionados =
                contexto.Testes.FindAll(t => t.Materia.Id == materia.Id);

            foreach (Teste t in testesRelacionados)
                t.Materia = null;

            return base.Excluir(id);
        }
    }
}
