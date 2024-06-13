//using GeradorDeTestesWinApp.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestesWinApp.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private Materia materia { get; set; }

        public Materia Materia
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
            }
            get
            {
                return materia;
            }
        }

        public TelaMateriaForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            string nome = txtNome.Text;
            SerieMateriaEnum serie;

            if (!rdb1Serie.Checked && !rdb2Serie.Checked)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma serie selecionada",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

                serie = 0;
            }

            else if (rdb1Serie.Checked)
                serie = SerieMateriaEnum.PrimeiraSerie;
            else
                serie = SerieMateriaEnum.SegundaSerie;
                             
            materia = new Materia(nome, serie);

            List<string> erros = materia.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

        }
    }
}
