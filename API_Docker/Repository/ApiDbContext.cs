using API_Docker.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Docker.Repository
{
    public class ApiDbContext : DbContext
    {

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
