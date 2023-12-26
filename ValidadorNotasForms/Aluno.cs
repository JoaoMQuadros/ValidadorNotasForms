using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoProjetoValidaNotasForms
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string AlunoNome { get; set; }
        public List<Notas> lstNotas = new List<Notas>();
        public double NotaID { get; set; }

    }
    public class Notas
    {
        public string NomeMateria { get; set; }
        public double NotaID { get; set; }
        public double RecebeNota { get; set; }

    }

    public class NomeMateria
    {
        public int IDNomeMateria { get; set; }
        public string Materias { get; set; }
    }
}