using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestesWinApp.ModuloQuestao
{
    public partial class TelaQuestaoForm : Form
    {
        private Questao questao;
        public Questao Questao
        {
            get { return questao; }

            set
            {
                txtId.Text = value.Id.ToString();
                txtEnunciado.Text = value.Enunciado;
                cmbMaterias.SelectedItem = value.Materia;
                txtAlternativaA.Text = value.Alternativas[0].Resposta;
                txtAlternativaB.Text = value.Alternativas[1].Resposta;
                txtAlternativaC.Text = value.Alternativas[2].Resposta;
                txtAlternativaD.Text = value.Alternativas[3].Resposta; 
                checarRespostaCorreta(value.Alternativas);
            }
        }

        private void checarRespostaCorreta(List<Alternativa> alternativas)
        {
            if (alternativas.Count == 0) { return; }
            foreach (var resposta in alternativas)
            {
                if (resposta.Status == true)
                {
                    if (alternativas.IndexOf(resposta) == 0)
                        checkAlternativaA.Checked = true;

                    if (alternativas.IndexOf(resposta) == 1)
                        checkAlternativaB.Checked = true;

                    if (alternativas.IndexOf(resposta) == 2)
                        checkAlternativaC.Checked = true;

                    if (alternativas.IndexOf(resposta) == 3)
                        checkAlternativaD.Checked = true;
                }
            }
        }


        public TelaQuestaoForm()
        {
            InitializeComponent();
        }

        public void CarregarMaterias(List<Materia> materias)
        {
            cmbMaterias.Items.Clear();

            foreach (Materia m in materias)
                cmbMaterias.Items.Add(m);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Materia materia = cmbMaterias.SelectedItem as Materia;
            string enunciado = txtEnunciado.Text;

            List<Alternativa> alternativasSelecionadas = new List<Alternativa>()
            {
                new (txtAlternativaA.Text, checkAlternativaA.Checked),
                new (txtAlternativaB.Text, checkAlternativaB.Checked),
                new (txtAlternativaC.Text, checkAlternativaC.Checked),
                new (txtAlternativaD.Text, checkAlternativaD.Checked)
            };


            questao = new Questao(materia, enunciado, alternativasSelecionadas);

            List<string> erros = questao.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
