using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
       public class QualityControlConfiguration : BaseConfiguration<QualityControl>
       {
              public override void Configure(EntityTypeBuilder<QualityControl> builder)
              {
                     builder.ToTable("QualityControls");


                     builder.HasOne(x => x.Order)
                            .WithMany()
                            .HasForeignKey(x => x.OrderId)
                            .OnDelete(DeleteBehavior.Restrict);

                     builder.HasOne(x => x.WashingMachine)
                            .WithMany(x => x.WashingQualityControls)
                            .HasForeignKey(x => x.WashingMachineId)
                            .OnDelete(DeleteBehavior.Restrict);

                     builder.HasOne(x => x.DryingMachine)
                            .WithMany(x => x.DryingQualityControls)
                            .HasForeignKey(x => x.DryingMachineId)
                            .OnDelete(DeleteBehavior.Restrict);

                     builder.HasOne(x => x.SpinningMachine)
                            .WithMany(x => x.SpinningQualityControls)
                            .HasForeignKey(x => x.SpinningMachineId)
                            .OnDelete(DeleteBehavior.Restrict);


                     builder.Property(x => x.BrandNo).HasMaxLength(50).IsRequired();
                     builder.Property(x => x.SupervisorNote).HasMaxLength(250); // Zorunlu değil (IsRequired yok)

                     builder.Property(x => x.TotalQuantity).IsRequired();
                     builder.Property(x => x.ControlledQuantity).IsRequired();
                     
                     builder.Property(x => x.MachineOperatorId).IsRequired();
                     builder.HasOne(x => x.MachineOperator)
                            .WithMany()
                            .HasForeignKey(x => x.MachineOperatorId)
                            .OnDelete(DeleteBehavior.Restrict);

                     builder.Property(x => x.SupervisorId).IsRequired();
                     builder.HasOne(x => x.Supervisor)
                            .WithMany()
                            .HasForeignKey(x => x.SupervisorId)
                            .OnDelete(DeleteBehavior.Restrict);

                     builder.Property(x => x.StartTime).IsRequired();
                     builder.Property(x => x.EndTime).IsRequired();
                     builder.Property(x => x.Shift).IsRequired();
                     builder.Property(x => x.Duration).IsRequired().HasConversion<long>();

                     builder.HasQueryFilter(x => !x.IsDeleted);

                     base.Configure(builder);
              }
       }
}