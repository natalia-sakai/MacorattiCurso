using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade6._1.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
    }
}
