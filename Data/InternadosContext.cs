using ApiInternados.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace ApiInternados.Data
{
    public class InternadosContext : DbContext
    {
        public InternadosContext(DbContextOptions<InternadosContext> options)
            : base(options)
        {
        }

        public DbSet<Internado> Internado { get; set; }




    }
}
