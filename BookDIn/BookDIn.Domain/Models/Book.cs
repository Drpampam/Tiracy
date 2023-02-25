using BookDIn.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDIn.Domain.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public BookCategory BookCategory { get; set; }//book categories e.g Most recent, most popular etc
        public string ISBN { get; set; } = null!;
        public Genre Genre { get; set; } 
        public int Pages { get; set; }
        public string PublicationDate { get; set; } = null!;
        public decimal Price { get; set; }
        public Availability IsAvailable { get; set; }
        public string DateAvailable { get; set; }
        public string DateExpired { get; set; }
        public string Language { get; set; } = null!;
        public string ImageURL { get; set; } = null!;
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public Library Library { get; set;}
    }
}