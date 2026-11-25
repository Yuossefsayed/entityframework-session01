
using BookStore.Data;
using BookStore.Entities;
using Microsoft.EntityFrameworkCore;

using var context = new BookStoreContext();

// Check if database is empty
if (!context.Categories.Any())
{
    var category = new Category
    {
        Name = "Programming",
        Description = "Programming Books",
        IsActive = true
    };

    var author1 = new Author
    {
        FirstName = "Ahmed",
        LastName = "Ali",
        EmailAddress = "ahmed@gmail.com",
        Biography = "Software Developer",
        DateOfBirth = new DateTime(1990, 5, 10)
    };

    var author2 = new Author
    {
        FirstName = "Mohamed",
        LastName = "Sayed",
        EmailAddress = "mohamed@gmail.com",
        Biography = "Computer Science Writer",
        DateOfBirth = new DateTime(1985, 3, 15)
    };

    var book = new Book
    {
        Title = "Learn C#",
        ISBN = "123456789",
        Price = 250,
        NumberOfPages = 300,
        YearPublished = 2025,
        IsInStock = true,

        Category = category,
        Authors = new List<Author> { author1, author2 }
    };

    context.Books.Add(book);

    context.SaveChanges();

    Console.WriteLine("Data Inserted Successfully!");
}

// Display Books
var books = context.Books
    .Include(b => b.Category)
    .Include(b => b.Authors)
    .ToList();

foreach (var item in books)
{
    Console.WriteLine("----------------------");
    Console.WriteLine("Title: " + item.Title);
    Console.WriteLine("Price: " + item.Price);
    Console.WriteLine("Category: " + item.Category.Name);

    foreach (var author in item.Authors)
    {
        Console.WriteLine("Author: " + author.FirstName
            + " " + author.LastName);
    }
}
