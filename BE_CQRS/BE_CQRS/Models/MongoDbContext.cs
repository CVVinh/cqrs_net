using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Models.Entities.Core;
using MongoDB.Driver;

namespace BE_CQRS.Models
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MongoDatabase");
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<DetailInformationTypeProduct> DetailInformationTypeProducts => _database.GetCollection<DetailInformationTypeProduct>("DetailInformationTypeProducts");
        public IMongoCollection<InformationProduct> InformationProducts => _database.GetCollection<InformationProduct>("InformationProducts");
        public IMongoCollection<InformationTypeProduct> InformationTypeProducts => _database.GetCollection<InformationTypeProduct>("InformationTypeProducts");
        public IMongoCollection<Product> Products => _database.GetCollection<Product>("Products");
        public IMongoCollection<ProductUnit> ProductUnits => _database.GetCollection<ProductUnit>("ProductUnits");
        public IMongoCollection<TypeProduct> TypeProducts => _database.GetCollection<TypeProduct>("TypeProducts");
        public IMongoCollection<TypeUnit> TypeUnits => _database.GetCollection<TypeUnit>("TypeUnits");
        public IMongoCollection<Unit> Units => _database.GetCollection<Unit>("Units");
    }
}
