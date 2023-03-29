using BE_CQRS.Models.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BE_CQRS.Models.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductPg>
    {
        public void Configure(EntityTypeBuilder<ProductPg> builder)
        {
            builder.ToTable("Product", "public");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasColumnType("varchar(255)");
            builder.Property(e => e.Description).HasColumnType("text");
            builder.Property(e => e.TypeProductId).IsRequired();

            builder.Property(e => e.IsDeleted).HasDefaultValue(false);
            builder.Property(e => e.DateCreated).HasColumnType("date");
            builder.Property(e => e.DateUpdated).HasColumnType("date");
            builder.Property(e => e.DateDeleted).HasColumnType("date");

            builder
               .HasOne(e => e.TypeProduct)
               .WithMany(y => y.Product)
               .HasPrincipalKey(w => w.Id)
               .HasForeignKey(z => z.TypeProductId)
               .HasConstraintName("FK_TypePro_Pro")
               .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
