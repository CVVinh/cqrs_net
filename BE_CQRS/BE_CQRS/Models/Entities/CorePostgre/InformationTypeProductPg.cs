namespace BE_CQRS.Models.Entities.Core
{
    public class InformationTypeProductPg : BaseEntityPostgre
    {
        public int InformationProductId { get; set; }
        public int TypeProductId { get; set; }

        public TypeProductPg TypeProduct { get; set; }
        public InformationProductPg InformationProduct { get; set; }

        public ICollection<DetailInformationTypeProductPg>? DetailInformationTypeProduct { get; set; }

        public InformationTypeProductPg()
        {
            DetailInformationTypeProduct = new HashSet<DetailInformationTypeProductPg>();
        }
    }
}
