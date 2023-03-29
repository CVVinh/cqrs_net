namespace BE_CQRS.Models.Entities.Core
{
    public class Product : BaseEntityPostgre
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public int TypeProductId { get; set; }
        public TypeProduct TypeProduct { get; set; }

        public ICollection<ProductUnit>? ProductUnit { get; set; }
        public ICollection<DetailInformationTypeProduct>? DetailProductInformation { get; set; }

        public Product()
        {
            this.ProductUnit = new HashSet<ProductUnit>();
            this.DetailProductInformation = new HashSet<DetailInformationTypeProduct>();
        }
    }
}
