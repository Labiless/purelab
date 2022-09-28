using Microsoft.EntityFrameworkCore;
using purelab.Models;

namespace purelab.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Post> allPosts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
