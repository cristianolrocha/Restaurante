using Restaurante.Model.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Model
{
    [Table("Prato")]
    public class Prato : AuditableEntity<long>
    {
        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required]
        public decimal Preco { get; set; }
        
        [Required]
        public long RestauranteId { get; set; }

        [ForeignKey("RestauranteId")]
        public virtual Restaurante Restaurante { get; set; }
    }
}
