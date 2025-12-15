using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class QualityControlDetailConfiguration : IEntityTypeConfiguration<QualityControlDetail>
    {
        public void Configure(EntityTypeBuilder<QualityControlDetail> builder)
        {
            builder.ToTable("QualityControlDetails");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.QualityControl)
                   .WithMany() // QualityControl içinde ICollection<Detail> yoksa boş bırakılır
                   .HasForeignKey(x => x.QualityControlId)
                   .OnDelete(DeleteBehavior.Cascade); // Ana kontrol silinirse detaylar da silinsin

            builder.HasOne(x => x.Defect)
                   .WithMany()
                   .HasForeignKey(x => x.DefectId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.DefectQuantity).IsRequired();
        }
    }
}