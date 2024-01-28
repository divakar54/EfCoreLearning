using EfCoreLearning.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EfCoreLearning
{
    public class EfCoreDbContext : DbContext
    {
        public EfCoreDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
