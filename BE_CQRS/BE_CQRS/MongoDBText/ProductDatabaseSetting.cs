namespace BE_CQRS.MongoDBText
{
    public class ProductDatabaseSetting : IProductDatabaseSetting
    {
        public string CollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
}
