using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_EFCore.Models
{
    [Table("TipoSocios")]
    public class TipoSocio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int DuracaoEmMes { get; set; }
        [Required]
        public int TaxaDesconto { get; set; }
    }
}
