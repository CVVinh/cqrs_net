namespace BE_CQRS.Models.Entities
{
    public class BaseEntityPostgre
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int? UserCreated { get; set; }
        public int? UserUpdated { get; set; }
        public int? UserDeleted { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
