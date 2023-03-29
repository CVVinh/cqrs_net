using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BE_CQRS.Models.Entities.Core;

namespace BE_CQRS.Models.Configurations
{
    public class DetailInformationTypeProductConfiguration : IEntityTypeConfiguration<DetailInformationTypeProductPg>
    {
        public void Configure(EntityTypeBuilder<DetailInformationTypeProductPg> builder)
        {
            builder.ToTable("DetailInformationTypeProduct", "public");

            builder.HasKey(e => new
            {
                e.InformationTypeProductId,
                e.ProductId
            });
            builder.Property(e => e.InformationTypeProductId).IsRequired();
            builder.Property(e => e.ProductId).IsRequired();
            builder.Property(e => e.Content).HasColumnType("text");

            builder.Property(e => e.IsDeleted).HasDefaultValue(false);
            builder.Property(e => e.DateCreated).HasColumnType("date");
            builder.Property(e => e.DateUpdated).HasColumnType("date");
            builder.Property(e => e.DateDeleted).HasColumnType("date");

            builder
               .HasOne(e => e.InformationTypeProduct)
               .WithMany(y => y.DetailInformationTypeProduct)
               .HasPrincipalKey(w => w.Id)
               .HasForeignKey(z => z.InformationTypeProductId)
               .HasConstraintName("FK_InfoTypePro_DetailInfoTypePro")
               .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasOne(x => x.Product)
               .WithMany(y => y.DetailProductInformation)
               .HasPrincipalKey(w => w.Id)
               .HasForeignKey(z => z.ProductId)
               .HasConstraintName("FK_Pro_DetailPro")
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
