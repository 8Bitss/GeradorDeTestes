using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloMateria;

namespace GeradorDeTestesWinApp.ModuloQuestao
{
    public class Questao : EntidadeBase
    {
        public Materia Materia { get; set; }
        public string Enunciado { get; set; }
        public List<Alternativa> Alternativas { get; set; }

        public Questao()
        {
            
        }

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

            if(Materia == null)
                erros.Add("O campo \"Materia\" é obrigatório");

            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo \"Enunciado\" é obrigatório");

            foreach (Alternativa alternativa in Alternativas)
            {
                if (alternativa.Resposta == "")
                {
                    erros.Add("Os campos de \"Alternativas\" escolhidos são obrigatórios");
                    break;
                }
            }

            if(QtdRespostasCorretas() < 1)
                erros.Add("É obrigatório no mínimo uma resposta correta");

            if(QtdRespostasCorretas() > 1)
                erros.Add("É permitido o cadastro de somente uma alternativa correta");

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

        public int QtdRespostasCorretas()
        {
            int qtdCorretas = 0;

            foreach (var item in Alternativas)
            {
                if (item.Status == true)
                    qtdCorretas++;
            }

            return qtdCorretas;
        }

        public override string ToString()
        {
            return Enunciado;
        }
    }
}
