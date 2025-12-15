using System;
using Core.Entities;
using Core.Entities.Concrete;
using Core.Enums;

namespace Entities.Concrete
{
    public class QualityControl: BaseEntity
    {
        // --- İLİŞKİLER ---
    public int OrderId { get; set; }
    public virtual Order Order { get; set; }
    public int WashingMachineId { get; set; }
    public virtual Machine WashingMachine { get; set; }
    public int DryingMachineId { get; set; }
    public virtual Machine DryingMachine { get; set; }

    public int SpinningMachineId { get; set; }
    public virtual Machine SpinningMachine { get; set; }
    public int MachineOperatorId { get; set; }
    public virtual User MachineOperator { get; set; }
    public int SupervisorId { get; set; } 
    public virtual User Supervisor { get; set; }
    public ShiftType Shift { get; set; } 
    public string BrandNo { get; set; } 
    public int TotalQuantity { get; set; } 
    public int ControlledQuantity { get; set; } 

    public DateTime StartTime { get; set; } 
    public DateTime EndTime { get; set; } 
    public TimeSpan Duration { get; set; } 
    public QualityResult? Result { get; set; } 
    public ControlFinishType? FinishType { get; set; }
    public string SupervisorNote { get; set; }
    }
}