using BE_CQRS.Models.Entities;
using BE_CQRS.Models.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BE_CQRS.Models.Configurations
{
    public class TypeUnitConfiguration : IEntityTypeConfiguration<TypeUnit>
    {
        public void Configure(EntityTypeBuilder<TypeUnit> builder)
        {
            builder.ToTable("TypeUnit", "public");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasColumnType("varchar(255)");

            builder.Property(e => e.IsDeleted).HasDefaultValue(false);
            builder.Property(e => e.DateCreated).HasColumnType("date");
            builder.Property(e => e.DateUpdated).HasColumnType("date");
            builder.Property(e => e.DateDeleted).HasColumnType("date");

        }

    }
}
