namespace BE_CQRS.Models.Entities.Core
{
    public class TypeProductPg : BaseEntityPostgre
    {
        public string Name { get; set; }

        public int TypeUnitId { get; set; }
        public TypeUnitPg TypeUnit { get; set; }

        public ICollection<ProductPg> Product { get; set; }
        public ICollection<InformationTypeProductPg> InformationTypeProduct { get; set; }

        public TypeProductPg()
        {
            this.Product = new HashSet<ProductPg>();
            this.InformationTypeProduct = new HashSet<InformationTypeProductPg>();
        }
    }
}
