
namespace BookStore.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        // One-to-Many with Books
        public ICollection<Book> Books { get; set; }
            = new List<Book>();
    }
}
