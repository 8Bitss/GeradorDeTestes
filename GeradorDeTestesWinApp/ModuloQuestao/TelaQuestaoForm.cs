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

                PreencheAlternativasUsadas(value.Alternativas);

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

        private void PreencheAlternativasUsadas(List<Alternativa> alternativas)
        {
            foreach(Alternativa alternativa in alternativas)
            {
                if(alternativa.Opcao == LetraAlternativaEnum.A)
                {
                    txtAlternativaA.Text = alternativa.Resposta;
                }
                if(alternativa.Opcao == LetraAlternativaEnum.B)
                {
                    txtAlternativaB.Text = alternativa.Resposta;
                }
                if(alternativa.Opcao == LetraAlternativaEnum.C)
                {
                    txtAlternativaC.Text = alternativa.Resposta;
                }
                if(alternativa.Opcao == LetraAlternativaEnum.D)
                {
                    txtAlternativaD.Text = alternativa.Resposta;
                }

                if (alternativa.Opcao == LetraAlternativaEnum.E)
                {
                    checkAlternativaE.Enabled = true;
                    checkAlternativaE.Visible = true;
                    txtAlternativaE.Visible = true;
                    txtAlternativaE.Enabled = true;
                    btnAdicionarCampo.Enabled = false;
                    btnRemoverE.Enabled = true;
                    btnRemoverE.Visible = true;

                    txtAlternativaE.Text = alternativa.Resposta;
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

            List<Alternativa> alternativas = AlternativasEscolhidas();

            questao = new Questao(materia, enunciado, alternativas);

            List<string> erros = questao.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private List<Alternativa> AlternativasEscolhidas()
        {
            List<Alternativa> alternativas = new List<Alternativa>();

            if (checkAlternativaA.Enabled)
                alternativas.Add(new(LetraAlternativaEnum.A,txtAlternativaA.Text, checkAlternativaA.Checked));

            if (checkAlternativaB.Enabled)
                alternativas.Add(new(LetraAlternativaEnum.B, txtAlternativaB.Text, checkAlternativaB.Checked));

            if (checkAlternativaC.Enabled)
                alternativas.Add(new(LetraAlternativaEnum.C, txtAlternativaC.Text, checkAlternativaC.Checked));

            if (checkAlternativaD.Enabled)
                alternativas.Add(new(LetraAlternativaEnum.D, txtAlternativaD.Text, checkAlternativaD.Checked));

            if (checkAlternativaE.Enabled)
                alternativas.Add(new(LetraAlternativaEnum.E, txtAlternativaE.Text, checkAlternativaE.Checked));

            return alternativas;
        }

        #region Configurando Botoes de remover textbox
        private void btnRemoverA_Click(object sender, EventArgs e)
        {
            checkAlternativaA.Enabled = false;
            txtAlternativaA.Enabled = false;
        }
        private void btnRemoverB_Click(object sender, EventArgs e)
        {
            checkAlternativaB.Enabled = false;
            txtAlternativaB.Enabled = false;
        }
        private void btnRemoverC_Click(object sender, EventArgs e)
        {
            checkAlternativaC.Enabled = false;
            txtAlternativaC.Enabled = false;
        }
        private void btnRemoverD_Click(object sender, EventArgs e)
        {
            checkAlternativaD.Enabled = false;
            txtAlternativaD.Enabled = false;
        }

        private void btnReverterA_Click(object sender, EventArgs e)
        {
            checkAlternativaA.Enabled = true;
            txtAlternativaA.Enabled = true;
        }

        private void btnReverterB_Click(object sender, EventArgs e)
        {
            checkAlternativaB.Enabled = true;
            txtAlternativaB.Enabled = true;
        }
        private void btnReverterC_Click(object sender, EventArgs e)
        {
            checkAlternativaC.Enabled = true;
            txtAlternativaC.Enabled = true;
        }
        private void btnReverterD_Click(object sender, EventArgs e)
        {
            checkAlternativaD.Enabled = true;
            txtAlternativaD.Enabled = true;
        }

        private void btnAdicionarCampo_Click(object sender, EventArgs e)
        {
            checkAlternativaE.Enabled = true;
            checkAlternativaE.Visible = true;
            txtAlternativaE.Enabled = true;
            txtAlternativaE.Visible = true;

            btnAdicionarCampo.Enabled = false;
            btnRemoverE.Visible = true;
        }

        private void btnRemoverE_Click(object sender, EventArgs e)
        {
            checkAlternativaE.Enabled = false;
            checkAlternativaE.Visible = false;
            txtAlternativaE.Enabled = false;
            txtAlternativaE.Visible = false;

            btnAdicionarCampo.Enabled = true;
            btnRemoverE.Visible = false;
        }
        #endregion
    }
}
