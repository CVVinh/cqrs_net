namespace BE_CQRS.MongoDBText
{
    public interface IProductDatabaseSetting
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
