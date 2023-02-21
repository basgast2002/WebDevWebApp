

using System.ComponentModel.DataAnnotations;

namespace WebDevWebApp.Models
{
    public class ContactModel
    {
        
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Subject { get; set; }
        [MaxLength(200)]
        public string Content { get; set; }
    }
}
