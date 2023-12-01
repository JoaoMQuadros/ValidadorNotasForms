using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorNotasForms
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public string NomeAluno { get; set; }
        public List<Notas> lstNotas = new List<Notas>();
    }
    public class Notas
    {
        public double NotaMat { get; set; }
        public double NotaPor { get; set; }
        public double NotaFis { get; set; }
    }
}
