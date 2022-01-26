using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevApp
{
    public interface IApplicationDbContext
    {
        DbSet<Langues> Langues { get; set; }
        Task<int> SaveChangesAsync();
    }
}
