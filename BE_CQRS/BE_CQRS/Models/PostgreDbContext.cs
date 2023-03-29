using BE_CQRS.Interface;
using BE_CQRS.Models.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BE_CQRS.Models
{
    public class PostgreDbContext : DbContext, IDbContext
    {
        public PostgreDbContext(DbContextOptions<PostgreDbContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        public virtual DbSet<DetailInformationTypeProductPg> DetailInformationTypeProducts { get; set; }
        public virtual DbSet<InformationProductPg> InformationProducts { get; set; }
        public virtual DbSet<InformationTypeProductPg> InformationTypeProducts { get; set; }
        public virtual DbSet<ProductPg> Products { get; set; }
        public virtual DbSet<ProductUnitPg> ProductUnits { get; set; }
        public virtual DbSet<TypeProductPg> TypeProducts { get; set; }
        public virtual DbSet<TypeUnitPg> TypeUnits { get; set; }
        public virtual DbSet<UnitPg> Units { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
