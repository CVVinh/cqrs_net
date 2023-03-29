namespace BE_CQRS.Models.Entities.Core
{
    public class TypeProduct : BaseEntityPostgre
    {
        public string Name { get; set; }

        public int TypeUnitId { get; set; }
        public TypeUnit TypeUnit { get; set; }

        public ICollection<Product> Product { get; set; }
        public ICollection<InformationTypeProduct> InformationTypeProduct { get; set; }

        public TypeProduct()
        {
            this.Product = new HashSet<Product>();
            this.InformationTypeProduct = new HashSet<InformationTypeProduct>();
        }
    }
}
