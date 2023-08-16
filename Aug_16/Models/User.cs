using System.ComponentModel.DataAnnotations;

namespace Jwt.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;    
        public string UserEmail { get; set; } 
        public string Password { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }

    }
}
