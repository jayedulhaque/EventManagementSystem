namespace AuthService.Models
{
    public class LoginDto
    {
        public string Username { get; set; } // Required for identifying the user
        public string Password { get; set; } // Password for authentication
    }
}
