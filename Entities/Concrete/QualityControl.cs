using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;
using Core.Enums;

namespace Entities.Concrete
{
    public class QualityControl: BaseEntity
    {
        // --- İLİŞKİLER ---
    [Required]
    public int OrderId { get; set; }
    [ForeignKey("OrderId")]
    public virtual Order Order { get; set; }

    [Required]
    public int WashingMachineId { get; set; }
    [ForeignKey("WashingMachineId")]
    public virtual Machine WashingMachine { get; set; }

    [Required]
    public int DryingMachineId { get; set; }
    [ForeignKey("DryingMachineId")]
    public virtual Machine DryingMachine { get; set; }

    [Required]
    public int SpinningMachineId { get; set; }
    [ForeignKey("SpinningMachineId")]
    public virtual Machine SpinningMachine { get; set; }

    // --- DATA ALANLARI ---

    [Required]
    public int MachineOperatorId { get; set; } 

    [Required]
    public int SupervisorId { get; set; } 

    [Required]
    // Gündüz/Gece seçimi
    public ShiftType Shift { get; set; } 

    [Required]
    [StringLength(50)]
    public string BrandNo { get; set; } 

    [Required]
    public int TotalQuantity { get; set; } 

    [Required]
    public int ControlledQuantity { get; set; } 

    public DateTime StartTime { get; set; } 
    public DateTime EndTime { get; set; } 

    [Required]
    public TimeSpan Duration { get; set; } 

    // --- SONUÇ ALANLARI ---

    // %15 kuralına göre hesaplanan sonuç (Passed/Failed)
    public QualityResult? Result { get; set; } 

    // Kullanıcının tıkladığı butona göre işlem (Sevk, Tamir vb.)
    // Başlangıçta boş olacağı için nullable (?) yaptık.
    public ControlFinishType? FinishType { get; set; }

    [MaxLength(250)]
    public string SupervisorNote { get; set; }
    }
}