namespace BE_CQRS.Models.Entities.Core
{
    public class ProductUnit : BaseEntityPostgre
    {
        public int ProductId { get; set; }
        public int UnitId { get; set; }
        public Product Product { get; set; }
        public Unit Unit { get; set; }
    }
}
