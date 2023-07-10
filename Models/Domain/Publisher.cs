using System.ComponentModel.DataAnnotations;

namespace BookMastermanagerCoreMVC6.Models.Domain
{
    public class Publisher
    {
        public int Id { get; set; }
        [Required]
        public string PublisherName { get; set; }
    }
}
