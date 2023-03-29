namespace BE_CQRS.Models.Entities.Core
{
    public class ProductUnitPg : BaseEntityPostgre
    {
        public int ProductId { get; set; }
        public int UnitId { get; set; }
        public ProductPg Product { get; set; }
        public UnitPg Unit { get; set; }
    }
}
