﻿using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;
using GeradorDeTestesWinApp.ModuloQuestao;

namespace GeradorDeTestesWinApp.ModuloTeste
{
    public class Teste : EntidadeBase
    {
        public string Titulo { get; set; }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public int QtdQuestoes { get; set; }
        public RecuperacaoEnum Recuperacao { get; set; }

        public List<Questao> QuestoesSelecionadas { get; set; }

        public Teste()
        {
            
        }

        public Teste(string titulo, Disciplina disciplina, Materia materia, int qtdQuestoes, List<Questao> questoesSelecinadas, RecuperacaoEnum recuperacao)
        {
            Titulo = titulo;
            Disciplina = disciplina;
            Materia = materia;
            QtdQuestoes = qtdQuestoes;

            QuestoesSelecionadas = questoesSelecinadas;
            Recuperacao = recuperacao;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Teste novoTeste = (Teste)novoRegistro;

            Titulo = novoTeste.Titulo;
            Disciplina = novoTeste.Disciplina;
            Materia = novoTeste.Materia;
            QtdQuestoes = novoTeste.QtdQuestoes;
            Recuperacao = novoTeste.Recuperacao;
            QuestoesSelecionadas = novoTeste.QuestoesSelecionadas;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"Título\" é obrigatório");
            
            if (Disciplina == null)
                erros.Add("O campo \"Disciplina\" é obrigatório");
            
            if (Materia == null && Recuperacao == RecuperacaoEnum.Nao)
                erros.Add("O campo \"Matéria\" é obrigatório");

            if(QtdQuestoes <= 0)
                erros.Add("O campo \"Qtd. Questões\" é obrigatório");

            if(QuestoesSelecionadas.Count == 0)
                erros.Add("É necessário gerar questões antes de cadastrar");




            return erros;
        }
    }
}
