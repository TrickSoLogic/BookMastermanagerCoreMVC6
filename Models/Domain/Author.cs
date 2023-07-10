using System.ComponentModel.DataAnnotations;

namespace BookMastermanagerCoreMVC6.Models.Domain
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string AuthorName { get; set; }
    }
}
