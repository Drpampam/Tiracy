using System.ComponentModel.DataAnnotations;

namespace BookDIn.Domain.Models
{
    public class Library
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}
