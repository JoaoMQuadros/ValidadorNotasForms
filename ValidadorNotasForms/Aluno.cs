using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorNotasForms
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string AlunoNome { get; set; }
        public List<Notas> lstNotas = new List<Notas>();
    }
    public class Notas
    {
        public int NotaID { get; set; }
        public int NotaArt { get; set; }
        public int NotaMat { get; set; }
        public int NotaPor { get; set; }
        public int NotaFis { get; set; }
    }
}
