using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloMateria;

namespace GeradorDeTestesWinApp.ModuloDisciplina
{
    public class Disciplina : EntidadeBase
    {
        public string Nome { get; set; }
        public List<Materia> Materias { get; set; }

        public Disciplina(string nome)
        {
            Nome = nome;

            Materias = new List<Materia>();
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Disciplina novoDisciplina = (Disciplina)novoRegistro;

            Nome = novoDisciplina.Nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O Nome precisa ser preenchido corretamente");

            return erros;
        }


        public override string ToString()
        {
            return Nome;
        }
    }
}