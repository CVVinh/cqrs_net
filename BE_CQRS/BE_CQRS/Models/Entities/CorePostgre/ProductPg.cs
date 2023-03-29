namespace BE_CQRS.Models.Entities.Core
{
    public class ProductPg : BaseEntityPostgre
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public int TypeProductId { get; set; }
        public TypeProductPg TypeProduct { get; set; }

        public ICollection<ProductUnitPg>? ProductUnit { get; set; }
        public ICollection<DetailInformationTypeProductPg>? DetailProductInformation { get; set; }

        public ProductPg()
        {
            this.ProductUnit = new HashSet<ProductUnitPg>();
            this.DetailProductInformation = new HashSet<DetailInformationTypeProductPg>();
        }
    }
}
