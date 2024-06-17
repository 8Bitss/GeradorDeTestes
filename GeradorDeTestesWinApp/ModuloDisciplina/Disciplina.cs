using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloMateria;
using GeradorDeTestesWinApp.ModuloQuestao;
using GeradorDeTestesWinApp.ModuloTeste;
using System.Text.Json.Serialization;

namespace GeradorDeTestesWinApp.ModuloDisciplina
{
    public class Disciplina : EntidadeBase
    {
        public string Nome { get; set; }
        public List<Materia> Materias { get; set; }
        public List<Questao> Questoes { get; set; }

        public Disciplina()
        {
            

        }

        public Disciplina(string nome)
        {
            Nome = nome;

            Materias = new List<Materia>();
            Questoes = new List<Questao>();
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

        public void AdicionarMaterias(Materia materiaSelecionada)
        {
            Materias.Add(materiaSelecionada);
        }

        public void AdicionarQuestao(Questao questaoSelecionada)
        {
            Questoes.Add(questaoSelecionada);
        }

        public List<Questao> PegarQuestoes(RepositorioQuestaoEmMemoria repositorioQuestao)
        {
            var questoes = repositorioQuestao.SelecionarTodos();
            foreach (var questao in questoes)
            {
                foreach (var materia in Materias)
                {
                    if (questao.Materia == materia)
                    {
                        AdicionarQuestao(questao);
                    }
                }
            }

            return Questoes;
        }
    }
}