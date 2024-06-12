using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloMateria;

namespace GeradorDeTestesWinApp.ModuloQuestoes
{
    public class Questoes : EntidadeBase
    {
        public string Materia {  get; set; }
        public string Enunciado {  get; set; }
        public string Alternativas {  get; set; }
        
        public Questoes(string materia, string enunciado, string alternativas)
        {
            Materia = materia;
            Enunciado = enunciado;
            Alternativas = alternativas;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questoes novaQuestoes = (Questoes)novoRegistro;
            
            Materia = novaQuestoes.Materia;
            Enunciado = novaQuestoes.Enunciado;
            Alternativas = novaQuestoes .Alternativas;  
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            
            if (string.IsNullOrEmpty(Materia.Trim()))
                erros.Add("O campo Matéria precisa ser preenchido corretamente.");

            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo Enunciado precisa ser preenchido corretamente.");

            if (string.IsNullOrEmpty(Alternativas.Trim()))
                erros.Add("O campo Alternativas precisa ser preenchido corretamente.");

            return erros;
        }
    }
}