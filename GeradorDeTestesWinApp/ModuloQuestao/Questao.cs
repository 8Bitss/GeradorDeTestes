using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloMateria;

namespace GeradorDeTestesWinApp.ModuloQuestao
{
    public class Questao : EntidadeBase
    {
        public Materia Materia { get; set; }
        public string Enunciado { get; set; }
        public string Alternativas { get; set; }

        public Questao(string enunciado)
        {
            Enunciado = enunciado;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questao novaQuestao = (Questao)novoRegistro;

            Materia = novaQuestao.Materia;
            Enunciado = novaQuestao.Enunciado;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo \"Enunciado\" é obrigatório");

            return erros;
        }
    }
}
