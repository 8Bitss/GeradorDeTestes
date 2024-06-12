using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloDisciplina;

namespace GeradorDeTestesWinApp.ModuloMateria
{
    public class Materia : EntidadeBase
    {
        public string Nome { get; set; } 
        public string Disciplina { get; set; }
        public string Serie { get; set; }

        public Materia( string nome, string disciplina, string serie) 
        {
            Nome = nome;
            Disciplina = disciplina;
            Serie = serie;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Materia novoMateria = (Materia)novoRegistro;

            Nome = novoMateria.Nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim())) ;
            erros.Add("O Nome da matéria precisa ser preenchido corretamente");

            if (string.IsNullOrEmpty(Disciplina.Trim())) ;
            erros.Add("A Disciplina precisa ser informada corretamente");

            if (string.IsNullOrEmpty(Serie.Trim())) ;
            erros.Add("A Série precisa ser informada corretamente");
            
            return erros;
        }
    }
}