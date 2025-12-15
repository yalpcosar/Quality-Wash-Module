using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class DefectConfiguration : IEntityTypeConfiguration<Defect>
    {
        public void Configure(EntityTypeBuilder<Defect> builder)
        {
            builder.ToTable("Defects");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.ColorCode).HasMaxLength(7).IsRequired(); // Örn: #FFFFFF
            builder.Property(x => x.IsDefect).IsRequired();
            builder.Property(x => x.SequenceNo).IsRequired();
            builder.Property(x => x.SectionType).IsRequired();
        }
    }
}