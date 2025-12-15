using System.ComponentModel.DataAnnotations;
using Core.Entities;
using Core.Enums;

namespace Entities.Concrete
{
    public class Defect : BaseEntity
    {
        public string Name { get; set; }
        public bool IsDefect { get; set; }
        public int SequenceNo { get; set; }
        public SectionType SectionType { get; set; }
        public string ColorCode { get; set; }
    }
}
