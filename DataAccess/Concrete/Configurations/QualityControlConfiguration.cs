using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class QualityControlConfiguration : IEntityTypeConfiguration<QualityControl>
    {
        public void Configure(EntityTypeBuilder<QualityControl> builder)
        {
            builder.ToTable("QualityControls");
            builder.HasKey(x => x.Id);

            // İlişkiler (Foreign Keys) ve Silme Davranışları
            builder.HasOne(x => x.Order)
                   .WithMany()
                   .HasForeignKey(x => x.OrderId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.WashingMachine)
                   .WithMany()
                   .HasForeignKey(x => x.WashingMachineId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.DryingMachine)
                   .WithMany()
                   .HasForeignKey(x => x.DryingMachineId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.SpinningMachine)
                   .WithMany()
                   .HasForeignKey(x => x.SpinningMachineId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Property Ayarları
            builder.Property(x => x.BrandNo).HasMaxLength(50).IsRequired();
            builder.Property(x => x.SupervisorNote).HasMaxLength(250); // Zorunlu değil (IsRequired yok)
            
            builder.Property(x => x.TotalQuantity).IsRequired();
            builder.Property(x => x.ControlledQuantity).IsRequired();
            builder.Property(x => x.MachineOperatorId).IsRequired();
            builder.Property(x => x.SupervisorId).IsRequired();
            builder.Property(x => x.Shift).IsRequired();
            builder.Property(x => x.Duration).IsRequired();

            // Nullable enumlar için IsRequired yazmıyoruz
        }
    }
}