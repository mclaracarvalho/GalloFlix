using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GalloFlix.Data;

    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
