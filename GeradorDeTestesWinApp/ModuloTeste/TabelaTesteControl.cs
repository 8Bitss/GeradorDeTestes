﻿using GeradorDeTestesWinApp.Compartilhado;
using GeradorDeTestesWinApp.ModuloMateria;

namespace GeradorDeTestesWinApp.ModuloTeste
{
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Teste> testes)
        {
            grid.Rows.Clear();

            foreach (Teste t in testes)
                if(t.Materia == null)
                    grid.Rows.Add(t.Id, t.Titulo, t.Disciplina.Nome, t.Materia, t.QtdQuestoes, t.Recuperacao);
                else
                    grid.Rows.Add(t.Id, t.Titulo, t.Disciplina.Nome, t.Materia.Nome, t.QtdQuestoes, t.Recuperacao);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Título" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Matéria" },
                new DataGridViewTextBoxColumn { DataPropertyName = "QtdQuestoes", HeaderText = "Quantidade de Questões" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Recuperacao", HeaderText = "Recuperação" }
            };
        }
    }
}
