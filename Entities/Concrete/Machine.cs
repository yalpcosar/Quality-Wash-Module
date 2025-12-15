using System.ComponentModel.DataAnnotations;
using Core.Entities;
using Core.Enums;

namespace Entities.Concrete
{
    public class Machine: BaseEntity
    {
        public string Name { get; set; }
        public MachineType MachineType { get; set; }
    }
}