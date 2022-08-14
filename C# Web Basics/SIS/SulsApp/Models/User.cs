namespace SulsApp.Models
{
    public class User
    {
        public string Id { get; set; }
        
        [MaxLength(20)]
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}