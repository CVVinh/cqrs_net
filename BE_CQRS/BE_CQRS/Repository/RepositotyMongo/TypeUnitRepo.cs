using BE_CQRS.Models.Entities.CoreMongo;
using BE_CQRS.MongoDBText;
using MongoDB.Driver;

namespace BE_CQRS.Repository.RepositotyMongo
{
    public interface ITypeUnitRepo
    {
        List<TypeUnit> Get();
        TypeUnit GetProject(string id);
        Task<TypeUnit> Create(TypeUnit project);
        void Update(TypeUnit project, string id);
        void Delete(string id);
    }

    public class TypeUnitRepo : ITypeUnitRepo
    {
        private readonly IMongoCollection<TypeUnit> _typeUnit;

        public TypeUnitRepo(IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase("TestDB");
            _typeUnit = database.GetCollection<TypeUnit>("TypeUnit");
        }
     
        public async Task<TypeUnit> Create(TypeUnit project)
        {
            await  _typeUnit.InsertOneAsync(project);
            return project;
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<TypeUnit> Get()
        {
            return _typeUnit.Find(project => true).ToList();
        }

        public TypeUnit GetProject(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(TypeUnit project, string id)
        {
            throw new NotImplementedException();
        }
    }
}
