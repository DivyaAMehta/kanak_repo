using EntityFrameworkCore.Model;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Players> Students { get; set; }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
