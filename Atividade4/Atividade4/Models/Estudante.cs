using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade4.Models
{
    public class Estudante
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Inform o nome do estudante")]
        public string Nome { get; set; }
        public DateTime DataMatricula { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}
