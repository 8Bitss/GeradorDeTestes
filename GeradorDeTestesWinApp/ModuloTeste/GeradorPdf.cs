using Aspose.Pdf;
using Aspose.Pdf.Text;
using GeradorDeTestesWinApp.ModuloQuestao;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GeradorDeTestesWinApp.ModuloTeste
{
    public class GeradorPdf
    {
        private static readonly string _dataDir = "C:\\temp\\GeradordeTestes";

        public Teste teste;
    
        // Inicializar objeto de documento
        public static Document document = new Document();
            
        // Adicionar Página
        public Aspose.Pdf.Page page = document.Pages.Add();

        public GeradorPdf(Teste testeSelecionado, bool EhGabarito = false)
        {
            teste = testeSelecionado;
            CriandoPDF(EhGabarito);
            document = new Document();
        }

        private void CriarCabecalho()
        {
            // Add Header
            var header = new TextFragment($"{teste.Titulo}");
            header.TextState.Font = FontRepository.FindFont("Arial");
            header.TextState.FontSize = 24;
            header.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            //header.Position = new Position(130, 720);
            page.Paragraphs.Add(header);
        }

        public void CriandoPDF(bool EhGabarito)
        {
            CriarCabecalho();

            Separador();

            // Adicionar texto à nova página
            var disciplinaTeste = new TextFragment($"Disciplina: {teste.Disciplina.Nome}");
            disciplinaTeste.TextState.FontSize = 10;
            page.Paragraphs.Add(disciplinaTeste);
            
            if(teste.Materia != null)
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Matéria: {teste.Materia.Nome}"));

            PularLinhas(2);

            var tituloQuestoes = new TextFragment("Questões");
            tituloQuestoes.TextState.Font = FontRepository.FindFont("Arial");
            tituloQuestoes.TextState.FontSize = 24;
            tituloQuestoes.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;

            page.Paragraphs.Add(tituloQuestoes);

            Separador();

            int i = 1;
            string check = string.Empty;
            if (!EhGabarito)
            {
                foreach (Questao questao in teste.QuestoesSelecionadas)
                {
                    AdicionarParagrafo($"{i} - {questao.Enunciado}");

                    for (int j = 0; j < questao.Alternativas.Count; j++)
                        AdicionarParagrafo($"[ ] {questao.Alternativas[j].Opcao}) {questao.Alternativas[j].Resposta}");
                    PularLinhas(1);
                    i++;
                }

                // Salvar PDF
                document.Save(System.IO.Path.Combine(_dataDir, $"{teste.Titulo}.pdf"));

                MessageBox.Show(
                    $"O arquivo: {teste.Titulo}.pdf, foi criado com sucesso!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            else
            {
                foreach (Questao questao in teste.QuestoesSelecionadas)
                {
                    AdicionarParagrafo($"{i} - {questao.Enunciado}");

                    for (int j = 0; j < questao.Alternativas.Count; j++)
                    {
                        if (questao.Alternativas[j].Status == false)
                        {
                            check = "  ";
                        }
                        else
                        {
                            check = "​🇽​";
                            
                        }
                        AdicionarParagrafo($"[{check}] {questao.Alternativas[j].Opcao}) {questao.Alternativas[j].Resposta}");
                    }
                    PularLinhas(1);
                    i++;
                }

                // Salvar PDF
                document.Save(System.IO.Path.Combine(_dataDir, $"{teste.Titulo}_Gabarito.pdf"));

                MessageBox.Show(
                    $"O arquivo: {teste.Titulo}_Gabarito.pdf, foi criado com sucesso!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        private void AdicionarParagrafo(string texto)
        {
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(texto));
        }

        private void Separador()
        {
            var linha = new TextFragment("________________________________________________________________________");
            linha.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(linha.Text));
            PularLinhas(1);

        }

        private void PularLinhas(int numeroLinhas)
        {
            for(int i = 0; i < numeroLinhas; i++)
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment());
        }
    }
}