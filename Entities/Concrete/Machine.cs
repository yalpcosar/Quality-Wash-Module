using System.ComponentModel.DataAnnotations;
using Core.Entities;
using Core.Enums;

namespace Entities.Concrete
{
    public class Machine: BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public MachineType MachineType { get; set; }
    }
}