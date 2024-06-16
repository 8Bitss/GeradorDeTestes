namespace GeradorDeTestesWinApp.ModuloQuestao
{
    public class Alternativa
    {
        public string Resposta { get; set; }
        public bool Status { get; set; }

        public Alternativa(string resposta, bool status)
        {
            Resposta = resposta;
            Status = status;
        }
    }
}