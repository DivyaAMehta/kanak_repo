using EntityFrameworkCore.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Players> Players { get; set; }
        IEnumerable<object> Players { get; }

        Task<int> SaveChanges();
    }
}
