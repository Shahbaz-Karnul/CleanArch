using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Journal.Domain.Models;
using Journal.Infrastructure.Repositories;

namespace Journal.Infrastructure.Data
{
    public class AppDBContext : DbContext

    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<Salat> Salats { get; set; }

    }

}
