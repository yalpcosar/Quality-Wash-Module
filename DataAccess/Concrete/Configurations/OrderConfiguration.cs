using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class OrderConfiguration : BaseConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            // OrderNo üzerinde index oluşturuyoruz (Hızlı arama için)
            builder.HasIndex(x => x.OrderNo).IsUnique();

            builder.Property(x => x.OrderNo).HasMaxLength(50).IsRequired();
            builder.Property(x => x.ModelName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.FabricType).HasMaxLength(50).IsRequired();

            // BaseEntity alanları
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.HasQueryFilter(x => !x.IsDeleted);

            base.Configure(builder);
        }
    }
}