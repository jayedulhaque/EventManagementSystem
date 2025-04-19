namespace AuthService.Model
{
    public class User
    {
        public Guid Id { get; set; } // Corresponds to _id in the SQL table
        public string Username { get; set; }
        public string Email { get; set; } // Add email field
        public string PasswordHash { get; set; } // Store hashed passwords
        public List<string> Roles { get; set; } // Use List<string> for multiple roles
        public UserProfile Profile { get; set; } // Nested object for profile
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
