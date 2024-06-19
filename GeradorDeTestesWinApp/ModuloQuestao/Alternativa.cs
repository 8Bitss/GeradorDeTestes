namespace GeradorDeTestesWinApp.ModuloQuestao
{
    public class Alternativa
    {
        public LetraAlternativaEnum Opcao { get; set; }
        public string Resposta { get; set; }
        public bool Status { get; set; }

        public Alternativa(LetraAlternativaEnum opcao,string resposta, bool status)
        {
            Opcao = opcao;
            Resposta = resposta;
            Status = status;
        }
    }
}