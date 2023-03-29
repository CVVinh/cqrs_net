namespace BE_CQRS.Models.Entities.Core
{
    public class TypeUnitPg : BaseEntityPostgre
    {
        public string Name { get; set; }

        public ICollection<TypeProductPg>? TypeProduct { get; set; }
        public ICollection<UnitPg>? Unit { get; set; }
        public TypeUnitPg()
        {
            this.TypeProduct = new HashSet<TypeProductPg>();
            this.Unit = new HashSet<UnitPg>();
        }
    }
}
