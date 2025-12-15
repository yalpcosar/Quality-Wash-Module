using System.Collections.Generic;
using Core.Entities;
using Core.Enums;

namespace Entities.Concrete
{
    public class Machine : BaseEntity
    {
        public string Name { get; set; }
        public MachineType MachineType { get; set; }
        public virtual ICollection<QualityControl> WashingQualityControls { get; set; }
        public virtual ICollection<QualityControl> DryingQualityControls { get; set; }
        public virtual ICollection<QualityControl> SpinningQualityControls { get; set; }

    }
}