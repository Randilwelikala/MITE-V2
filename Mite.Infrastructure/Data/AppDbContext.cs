
using Microsoft.EntityFrameworkCore;
using Mite.Core.Entities;

namespace Mite.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> option) : DbContext(option)
    {
        public DbSet<Student> Students => Set<Student>();
     

    }
}
