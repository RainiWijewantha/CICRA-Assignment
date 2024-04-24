using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class UserDetailsContext : DbContext
    {
        public UserDetailsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserDetail>  UserDetails { get; set; }
    }
}
