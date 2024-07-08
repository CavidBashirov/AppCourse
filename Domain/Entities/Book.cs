using Domain.Common;


namespace Domain.Entities
{
    public class Book : BaseEntity,IAuditableEntity
    {
        public string Name { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
