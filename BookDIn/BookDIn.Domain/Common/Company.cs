using BookDIn.Domain.Models;

namespace BookDIn.Domain.Common
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public DateTime EstablishedDate { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get;set; }
    }
}
