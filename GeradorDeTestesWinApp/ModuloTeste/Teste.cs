using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloTeste
{
    public class Teste : EntidadeBase   
    {
        public string Titulo {  get; set; }
        public string Disciplina { get; set;}
        public string Materia { get; set;}
        public string Serie { get; set;}
        public string QuantidadeDeQuestoes { get; set;}

        public Teste(string titulo, string disciplina, string materia, string serie, string quantidadedequestoes)
        {
            Titulo = titulo;
            Disciplina = disciplina;
            Materia = materia;
            Serie = serie;
            QuantidadeDeQuestoes = quantidadedequestoes;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Teste novoTeste = (Teste)novoRegistro;

            Titulo = novoTeste.Titulo;
            Disciplina = novoTeste.Disciplina;
            Materia= novoTeste.Materia; 
            Serie= novoTeste.Serie;
            QuantidadeDeQuestoes = novoTeste.QuantidadeDeQuestoes;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O titulo deve ser preenchido corretamente");

            if (string.IsNullOrEmpty(Disciplina.Trim()))
                erros.Add("O campo Disciplina deve ser preenchido corretamente");

            if (string.IsNullOrEmpty(Materia.Trim()))
                erros.Add("O campo Materia deve ser preenchido corretamente");

            if (string.IsNullOrEmpty(Serie.Trim()))
                erros.Add("A Serie deve ser preenchida corretamente");

            if (string.IsNullOrEmpty(QuantidadeDeQuestoes.Trim()))
                erros.Add("A Quantidade de Questões precisa ser preenchida corretamente");
                
            return erros;
        }     
    }
}