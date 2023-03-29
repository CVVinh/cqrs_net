namespace BE_CQRS.Models.Entities.Core
{
    public class UnitPg : BaseEntityPostgre
    {
        public string Name { get; set; }
        public int StanderNumber { get; set; } // hằng đơn vị chuẩn

        public int TypeUnitId { get; set; }
        public TypeUnitPg TypeUnit { get; set; }

        public ICollection<ProductUnitPg>? ProductUnit { get; set; }
        public UnitPg()
        {
            ProductUnit = new HashSet<ProductUnitPg>();
        }
    }
}
