using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloDisciplina;

namespace GeradorDeTestesWinApp.ModuloMateria
{
    public class Materia : EntidadeBase
    {
        public string Nome { get; set; }
        public Disciplina Disciplina { get; set; }
        public SerieMateriaEnum SerieMateria { get; set; }

        public Materia(string nome, Disciplina disciplina, SerieMateriaEnum serie) 
        {
            Nome = nome;
            Disciplina = disciplina;
            SerieMateria = serie;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Materia novaMateria = (Materia)novoRegistro;

            Nome = novaMateria.Nome;
            Disciplina = novaMateria.Disciplina;
            SerieMateria = novaMateria.SerieMateria;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
            erros.Add("O Nome da matéria precisa ser preenchido corretamente");

            if (Disciplina == null)
                erros.Add("A Disciplina precisa ser informada corretamente");

            if (SerieMateria == 0)
                erros.Add("A Série precisa ser informada corretamente");

            return erros;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}