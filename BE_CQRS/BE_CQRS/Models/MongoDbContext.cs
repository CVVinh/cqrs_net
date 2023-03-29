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

        protected IMongoCollection<T> GetCollection<T>(string name)
        {
            return _database.GetCollection<T>(name);
        }

        public IMongoCollection<DetailInformationTypeProductPg> DetailInformationTypeProducts => _database.GetCollection<DetailInformationTypeProductPg>("DetailInformationTypeProducts");
        public IMongoCollection<InformationProductPg> InformationProducts => _database.GetCollection<InformationProductPg>("InformationProducts");
        public IMongoCollection<InformationTypeProductPg> InformationTypeProducts => _database.GetCollection<InformationTypeProductPg>("InformationTypeProducts");
        public IMongoCollection<ProductPg> Products => _database.GetCollection<ProductPg>("Products");
        public IMongoCollection<ProductUnitPg> ProductUnits => _database.GetCollection<ProductUnitPg>("ProductUnits");
        public IMongoCollection<TypeProductPg> TypeProducts => _database.GetCollection<TypeProductPg>("TypeProducts");
        public IMongoCollection<TypeUnitPg> TypeUnits => _database.GetCollection<TypeUnitPg>("TypeUnits");
        public IMongoCollection<UnitPg> Units => _database.GetCollection<UnitPg>("Units");
    }
}
