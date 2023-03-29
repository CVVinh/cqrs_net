namespace BE_CQRS.Models.Entities.Core
{
    public class DetailInformationTypeProduct : BaseEntityPostgre
    {
        public int InformationTypeProductId { get; set; }
        public int ProductId { get; set; }
        public string Content { get; set; }
        public Product Product { get; set; }
        public InformationTypeProduct InformationTypeProduct { get; set; }
    }
}
