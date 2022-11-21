using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication2.Model;

namespace WebApplication2.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Players> Players { get; set; }

        Task<int> SaveChanges();
    }
}
