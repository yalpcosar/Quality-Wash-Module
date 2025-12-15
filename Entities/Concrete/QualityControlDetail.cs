using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities.Concrete
{
    public class QualityControlDetail: BaseEntity
    {
        public int QualityControlId { get; set; }
        public virtual QualityControl QualityControl { get; set; }
        public int DefectId { get; set; }
        public virtual Defect Defect { get; set; }
        public int DefectQuantity { get; set; }
    }
}