using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;

namespace GeradorDeTestesWinApp.ModuloTeste
{
    public class Teste : EntidadeBase
    {
        public string Titulo { get; set; }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public int QtdQuestoes { get; set; }

        public Teste(string titulo, Disciplina disciplina, Materia materia, int qtdQuestoes)
        {
            Titulo = titulo;
            Disciplina = disciplina;
            Materia = materia;
            QtdQuestoes = qtdQuestoes;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Teste novoTeste = (Teste)novoRegistro;

            Titulo = novoTeste.Titulo;
            Disciplina = novoTeste.Disciplina;
            Materia = novoTeste.Materia;
            QtdQuestoes = novoTeste.QtdQuestoes;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"Título\" é obrigatório");

            return erros;
        }
    }
}
