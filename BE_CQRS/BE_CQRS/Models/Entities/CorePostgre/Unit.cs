namespace BE_CQRS.Models.Entities.Core
{
    public class Unit : BaseEntityPostgre
    {
        public string Name { get; set; }
        public int StanderNumber { get; set; } // hằng đơn vị chuẩn

        public int TypeUnitId { get; set; }
        public TypeUnit TypeUnit { get; set; }

        public ICollection<ProductUnit>? ProductUnit { get; set; }
        public Unit()
        {
            ProductUnit = new HashSet<ProductUnit>();
        }
    }
}
