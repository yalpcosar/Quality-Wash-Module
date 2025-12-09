using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities.Concrete
{
    public class QualityControlDetail: BaseEntity
    {
        [Required]
        public int QualityControlId { get; set; }

        [ForeignKey("QualityControlId")]
        public virtual QualityControl QualityControl { get; set; }

        [Required]
        public int DefectId { get; set; }

        [ForeignKey("DefectId")]
        public virtual Defect Defect { get; set; }


        [Required]
        public int DefectQuantity { get; set; }
    }
}