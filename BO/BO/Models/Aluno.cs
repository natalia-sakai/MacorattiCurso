using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BO.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50,MinimumLength =5, ErrorMessage ="Compo obrigatório, minimo 5 letras")]
        [Display(Name="Informe o nome do cliente")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Informe o sexo do cliente")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [EmailAddress(ErrorMessage ="Email inválildo")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Nascimento { get; set; }

        public string Foto { get; set; }

        public string Texto { get; set; }
    }
}
