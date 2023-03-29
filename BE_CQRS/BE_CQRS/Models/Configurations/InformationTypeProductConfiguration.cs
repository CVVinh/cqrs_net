using BE_CQRS.Models.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BE_CQRS.Models.Configurations
{
    public class InformationTypeProductConfiguration : IEntityTypeConfiguration<InformationTypeProductPg>
    {
        public void Configure(EntityTypeBuilder<InformationTypeProductPg> builder)
        {
            builder.ToTable("InformationTypeProduct", "public");

            builder.HasKey(e => new
            {
                e.InformationProductId,
                e.TypeProductId
            });
            builder.Property(e => e.InformationProductId).IsRequired();
            builder.Property(e => e.TypeProductId).IsRequired();

            builder.Property(e => e.IsDeleted).HasDefaultValue(false);
            builder.Property(e => e.DateCreated).HasColumnType("date");
            builder.Property(e => e.DateUpdated).HasColumnType("date");
            builder.Property(e => e.DateDeleted).HasColumnType("date");

            builder
               .HasOne(e => e.InformationProduct)
               .WithMany(y => y.InformationTypeProduct)
               .HasPrincipalKey(w => w.Id)
               .HasForeignKey(z => z.InformationProductId)
               .HasConstraintName("FK_InfoPro_InfoTypePro")
               .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasOne(x => x.TypeProduct)
               .WithMany(y => y.InformationTypeProduct)
               .HasPrincipalKey(w => w.Id)
               .HasForeignKey(z => z.TypeProductId)
               .HasConstraintName("FK_TypePro_InfoTypePro")
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
