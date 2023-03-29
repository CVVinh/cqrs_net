namespace BE_CQRS.Models.Entities.Core
{
    public class DetailInformationTypeProductPg : BaseEntityPostgre
    {
        public int InformationTypeProductId { get; set; }
        public int ProductId { get; set; }
        public string Content { get; set; }
        public ProductPg Product { get; set; }
        public InformationTypeProductPg InformationTypeProduct { get; set; }
    }
}
