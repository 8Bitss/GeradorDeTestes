using GeradorDeTestesWinApp.Compartilhado;

namespace GeradorDeTestesWinApp.ModuloMateria
{
    internal class Materia : EntidadeBase  
    {
        public string Nome { get; set; }
        public string Disciplina { get; set; }
        public string Serie { get; set; }
     
     public Materia(string nome, string disciplina, string serie)
     {
            Nome = nome;
            Disciplina = disciplina;
            Serie = serie;
     }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Materia novaMateria = (Materia) novoRegistro;

            Nome = novaMateria.Nome;
            Disciplina = novaMateria.Disciplina;    
            Serie = novaMateria.Serie;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O Campo Nome precisa ser preenchido corretamente");

            if (string.IsNullOrEmpty(Disciplina.Trim()))
                erros.Add("O Campo Disciplina precisa ser preenchido corretamente");

            if (string.IsNullOrEmpty(Serie.Trim()))
                erros.Add("O campo série precisa ser prenchido corretamente");

            return erros;
        }
    }
}
