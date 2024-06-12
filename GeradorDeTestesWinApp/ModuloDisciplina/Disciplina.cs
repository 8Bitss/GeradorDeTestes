using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloDisciplina
{
    public class Disciplina : EntidadeBase
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Disciplina { get; set; }

        public Disciplina(string id, string nome, string disciplina)
        {
            Id = id;
            Nome = nome;
            Disciplina = disciplina;
        }
        
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Disciplina novoDisciplina = (Disciplina)novoRegistro;   
            Id = novoDisciplina.Id;
            Nome = novoDisciplina.Nome;
            Disciplina = novoDisciplina.Disciplina;
        }
        
        public override List<string> Validar()
        {
         List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Id.Trim()));
            erros.Add("O Id precisa ser preenchido corretamente");

            if (string.IsNullOrEmpty(Nome.Trim()));
            erros.Add("O Nome precisa ser preenchido corretamente");

            if (string.IsNullOrEmpty(Disciplina.Trim()));
            erros.Add("A Disciplina precisa ser preenchida corretamente");

            return erros;
        }        
    }
}