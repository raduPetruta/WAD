using Microsoft.EntityFrameworkCore;
using wad_backend.Models;

namespace wad_backend.Context
{
    public class SocialMediaContext : DbContext
    {
        public SocialMediaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<PostModel> Posts { get; set; }
    } 
}
