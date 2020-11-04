using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade4.Models
{
    public class Curso
    {
        public int CursoId { get; set; }

        [Required(ErrorMessage ="Informe o nome do curso")]
        public string Titulo { get; set; }
        public int Creditos { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}
