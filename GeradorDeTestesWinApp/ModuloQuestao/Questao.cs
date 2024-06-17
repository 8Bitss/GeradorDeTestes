using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloMateria;

namespace GeradorDeTestesWinApp.ModuloQuestao
{
    public class Questao : EntidadeBase
    {
        public Materia Materia { get; set; }
        public string Enunciado { get; set; }
        public List<Alternativa> Alternativas { get; set; }

        public Questao(Materia materia, string enunciado, List<Alternativa> alternativas)
        {
            Materia = materia;
            Enunciado = enunciado;
            Alternativas = alternativas;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questao novaQuestao = (Questao)novoRegistro;

            Materia = novaQuestao.Materia;
            Enunciado = novaQuestao.Enunciado;
            Alternativas = novaQuestao.Alternativas;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            
            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo \"Enunciado\" é obrigatório");

            return erros;
        }

        public string RespostasCorretas()
        {
            string respostas = "";
            foreach (var item in Alternativas)
            {
                if (item.Status == true)
                    respostas += item.Resposta + "  | \n";
            }

            return respostas;
        }

        public override string ToString()
        {
            return Enunciado;
        }
    }
}
