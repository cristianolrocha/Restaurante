using Restaurante.Model.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Model
{
    [Table("Restaurante")]
    public class Restaurante : AuditableEntity<long>
    {
        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }
        
        public virtual IEnumerable<Prato> Pratos { get; set; }
    }
}
