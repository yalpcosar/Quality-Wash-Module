using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order: BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string OrderNo { get; set; }
        
        [Required]
        [StringLength(100)]
        public string ModelName { get; set; }

        [Required]
        [StringLength(50)]
        public string FabricType { get; set; }
    }
}