using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class QualityControlDetailConfiguration : BaseConfiguration<QualityControlDetail>
    {
        public override void Configure(EntityTypeBuilder<QualityControlDetail> builder)
        {
            builder.ToTable("QualityControlDetails");

            builder.HasIndex(x => new { x.QualityControlId, x.DefectId }).IsUnique();

            builder.HasOne(x => x.QualityControl)
                   .WithMany() 
                   .HasForeignKey(x => x.QualityControlId)
                   .OnDelete(DeleteBehavior.Cascade); 

            builder.HasOne(x => x.Defect)
                   .WithMany()
                   .HasForeignKey(x => x.DefectId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.DefectQuantity).IsRequired();

            builder.HasQueryFilter(x => !x.IsDeleted);

            base.Configure(builder);
        }
    }
}