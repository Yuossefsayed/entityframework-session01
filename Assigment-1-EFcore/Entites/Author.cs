
namespace BookStore.Entities
{
    public class Author
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string Biography { get; set; }

        public DateTime DateOfBirth { get; set; }

        // Many-to-Many with Books
        public ICollection<Book> Books { get; set; }
            = new List<Book>();
    }
}
