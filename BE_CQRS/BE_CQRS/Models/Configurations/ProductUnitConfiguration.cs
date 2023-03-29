using BE_CQRS.Models.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BE_CQRS.Models.Configurations
{
    public class ProductUnitConfiguration : IEntityTypeConfiguration<ProductUnitPg>
    {
        public void Configure(EntityTypeBuilder<ProductUnitPg> builder)
        {
            builder.ToTable("ProductUnit", "public");

            builder.HasKey(e => new
            {
                e.UnitId,
                e.ProductId
            });
            builder.Property(e => e.UnitId).IsRequired();
            builder.Property(e => e.ProductId).IsRequired();

            builder.Property(e => e.IsDeleted).HasDefaultValue(false);
            builder.Property(e => e.DateCreated).HasColumnType("date");
            builder.Property(e => e.DateUpdated).HasColumnType("date");
            builder.Property(e => e.DateDeleted).HasColumnType("date");

            builder
               .HasOne(e => e.Unit)
               .WithMany(y => y.ProductUnit)
               .HasPrincipalKey(w => w.Id)
               .HasForeignKey(z => z.UnitId)
               .HasConstraintName("FK_Unit_ProUnit")
               .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasOne(x => x.Product)
               .WithMany(y => y.ProductUnit)
               .HasPrincipalKey(w => w.Id)
               .HasForeignKey(z => z.ProductId)
               .HasConstraintName("FK_Product_ProUnit")
               .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
