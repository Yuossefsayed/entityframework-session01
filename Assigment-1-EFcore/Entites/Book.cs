
namespace BookStore.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }

        public int NumberOfPages { get; set; }

        public int YearPublished { get; set; }

        public bool IsInStock { get; set; }

        // Relationship with Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Many-to-Many with Authors
        public ICollection<Author> Authors { get; set; }
            = new List<Author>();
    }
}
