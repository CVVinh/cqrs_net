using BE_CQRS.Models.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BE_CQRS.Models.Configurations
{
    public class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.ToTable("Unit", "public");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.TypeUnitId).IsRequired();
            builder.Property(e => e.Name).HasColumnType("varchar(255)");

            builder.Property(e => e.IsDeleted).HasDefaultValue(false);
            builder.Property(e => e.DateCreated).HasColumnType("date");
            builder.Property(e => e.DateUpdated).HasColumnType("date");
            builder.Property(e => e.DateDeleted).HasColumnType("date");

            builder
               .HasOne(e => e.TypeUnit)
               .WithMany(y => y.Unit)
               .HasPrincipalKey(w => w.Id)
               .HasForeignKey(z => z.TypeUnitId)
               .HasConstraintName("FK_TypeUnit_Unit")
               .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
