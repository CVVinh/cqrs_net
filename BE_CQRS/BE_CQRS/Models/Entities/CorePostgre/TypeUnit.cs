namespace BE_CQRS.Models.Entities.Core
{
    public class TypeUnit : BaseEntityPostgre
    {
        public string Name { get; set; }

        public ICollection<TypeProduct>? TypeProduct { get; set; }
        public ICollection<Unit>? Unit { get; set; }
        public TypeUnit()
        {
            this.TypeProduct = new HashSet<TypeProduct>();
            this.Unit = new HashSet<Unit>();
        }
    }
}
