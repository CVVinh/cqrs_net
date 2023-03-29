namespace BE_CQRS.Models.Entities.Core
{
    public class InformationTypeProduct : BaseEntityPostgre
    {
        public int InformationProductId { get; set; }
        public int TypeProductId { get; set; }

        public TypeProduct TypeProduct { get; set; }
        public InformationProduct InformationProduct { get; set; }

        public ICollection<DetailInformationTypeProduct>? DetailInformationTypeProduct { get; set; }

        public InformationTypeProduct()
        {
            DetailInformationTypeProduct = new HashSet<DetailInformationTypeProduct>();
        }
    }
}
