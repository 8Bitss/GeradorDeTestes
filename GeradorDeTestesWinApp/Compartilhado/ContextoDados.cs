﻿using GeradorDeTestesWinApp.ModuloDisciplina;
using GeradorDeTestesWinApp.ModuloMateria;
using GeradorDeTestesWinApp.ModuloQuestao;
using GeradorDeTestesWinApp.ModuloTeste;
using Microsoft.Win32;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace GeradorDeTestesWinApp.Compartilhado
{
    public class ContextoDados
    {
        public List<Disciplina> Disciplinas { get; set; }
        public List<Materia> Materias { get; set; }
        public List<Questao> Questoes { get; set; }
        public List<Teste> Testes { get; set; }

        private string caminho = $"C:\\temp\\GeradordeTestes\\dados.json";

        public ContextoDados()
        {
            Disciplinas = new List<Disciplina>();
            Materias = new List<Materia>();
            Questoes = new List<Questao>();
            Testes = new List<Teste>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDados();
        }

        public void Gravar()
        {
            FileInfo arquivo = new FileInfo(caminho);

            arquivo.Directory.Create();

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(this, options);

            File.WriteAllBytes(caminho, registrosEmBytes);
        }

        public void CarregarDados()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return;

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosEmBytes, options);

            if (ctx == null)
                return;
            
            Disciplinas = ctx.Disciplinas;

            Materias = ctx.Materias;

            Questoes = ctx.Questoes;

            Testes = ctx.Testes;
        }
    }
}
