using BookDIn.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace BookDIn.Domain.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public string PhoneNumber { get; set; }
        public string WebSite_Url { get; set; }
        public string Nationality { get; set; }
        public string ProfileUrl { get; set; }

        public int CompanyId { get; set; }
        public Company PublisherCompany { get; set; }

        public ICollection<Book> BooksPublished { get;}
    }
}