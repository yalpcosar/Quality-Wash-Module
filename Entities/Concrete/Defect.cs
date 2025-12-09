using System.ComponentModel.DataAnnotations;
using Core.Enums;

namespace Entities.Concrete
{
    public class Defect
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public bool IsDefect { get; set; }
        [Required]
        public int SequenceNo { get; set; }
        [Required]
        public SectionType SectionType { get; set; }
        [Required]
        [StringLength(7)]
        public string ColorCode { get; set; }

    }
}