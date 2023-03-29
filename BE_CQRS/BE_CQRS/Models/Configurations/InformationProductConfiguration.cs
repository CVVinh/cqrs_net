using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BE_CQRS.Models.Entities.Core;

namespace BE_CQRS.Models.Configurations
{
    public class InformationProductConfiguration : IEntityTypeConfiguration<InformationProductPg>
    {
        public void Configure(EntityTypeBuilder<InformationProductPg> builder)
        {
            builder.ToTable("InformationProduct", "public");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasColumnType("varchar(255)");
            builder.Property(e => e.Description).HasColumnType("text");

            builder.Property(e => e.IsDeleted).HasDefaultValue(false);
            builder.Property(e => e.DateCreated).HasColumnType("date");
            builder.Property(e => e.DateUpdated).HasColumnType("date");
            builder.Property(e => e.DateDeleted).HasColumnType("date");

        }
    }
}
