using BE_CQRS.Models.Entities.CoreMongo;
using BE_CQRS.MongoDBText;
using MongoDB.Driver;

namespace BE_CQRS.Repository.RepositotyMongo
{
    public interface ITypeUnitRepo
    {
        List<TypeUnitMg> Get();
        TypeUnitMg GetProject(string id);
        Task<TypeUnitMg> Create(TypeUnitMg project);
        void Update(TypeUnitMg project, string id);
        void Delete(string id);
    }

    public class TypeUnitRepoMg : ITypeUnitRepo
    {
        private readonly IMongoCollection<TypeUnitMg> _typeUnit;

        public TypeUnitRepoMg(IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase("TestDB");
            _typeUnit = database.GetCollection<TypeUnitMg>("TypeUnit");
        }
     
        public async Task<TypeUnitMg> Create(TypeUnitMg project)
        {
            await  _typeUnit.InsertOneAsync(project);
            return project;
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<TypeUnitMg> Get()
        {
            return _typeUnit.Find(project => true).ToList();
        }

        public TypeUnitMg GetProject(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(TypeUnitMg project, string id)
        {
            throw new NotImplementedException();
        }
    }
}
