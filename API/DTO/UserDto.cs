using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class UserDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Token { get; set; }
    }
}
