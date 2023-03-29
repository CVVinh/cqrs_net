namespace BE_CQRS.Models.Entities.Core
{
    public class InformationProductPg : BaseEntityPostgre
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<InformationTypeProductPg>? InformationTypeProduct { get; set; }

        public InformationProductPg()
        {
            InformationTypeProduct = new HashSet<InformationTypeProductPg>();
        }
    }
}
