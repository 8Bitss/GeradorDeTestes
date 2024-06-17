using GeradorDeTestesWinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestesWinApp.ModuloMateria
{
    public class RepositorioMateriaEmArquivo : RepositorioBaseEmArquivo<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaEmArquivo() : base("materias.json")
        {
            
        }
    }
}
