namespace BE_CQRS.Models.Entities.Core
{
    public class InformationProduct : BaseEntityPostgre
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<InformationTypeProduct>? InformationTypeProduct { get; set; }

        public InformationProduct()
        {
            InformationTypeProduct = new HashSet<InformationTypeProduct>();
        }
    }
}
