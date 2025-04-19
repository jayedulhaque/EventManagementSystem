using AuthService.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Database
{
    public class AuthDbContext: DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Roles).HasConversion(
                    roles => string.Join(',', roles),
                    rolesString => rolesString.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
                );
                entity.OwnsOne(u => u.Profile);
            });
        }
    }
}
