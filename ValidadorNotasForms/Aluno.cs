using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoProjetoValidaNotasForms
{
    public class Aluno
    {
        public int NomeID { get; set; }
        public string NomeAluno { get; set; }
        public List<Notas> notas = new List<Notas>();

    }
    public class Notas
    {
        public int NotaID { get; set; }
        public int NotaMat { get; set; }
        public int NotaFis { get; set; }
        public int NotaPor { get; set; }
        public int NotaArt { get; set; }
    }
}