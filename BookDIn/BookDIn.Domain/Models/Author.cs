using BookDIn.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace BookDIn.Domain
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public string Email { get; set; }
        public string Bio { get; set; }
        public string Nationality { get; set; }
        public string ProfileUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public ICollection<Book> BooksWritten { get; set; }
    }
}