using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);

            // OrderNo üzerinde index oluşturuyoruz (Hızlı arama için)
            builder.HasIndex(x => x.OrderNo); 

            builder.Property(x => x.OrderNo).HasMaxLength(50).IsRequired();
            builder.Property(x => x.ModelName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.FabricType).HasMaxLength(50).IsRequired();
            
            // BaseEntity alanları
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

        }
    }
}