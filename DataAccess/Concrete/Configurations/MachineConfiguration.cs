using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class MachineConfiguration : BaseConfiguration<Machine>
    {
        public  override void Configure(EntityTypeBuilder<Machine> builder)
        {
            builder.ToTable("Machines");

            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.MachineType).IsRequired(); // Enum int olarak tutulur
            builder.HasQueryFilter(x => !x.IsDeleted);
            
            base.Configure(builder);
        }
    }
}