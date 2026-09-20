using Frist_app.Models;
using Microsoft.EntityFrameworkCore;

namespace Frist_app.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> User { get; set; }
    }
}
