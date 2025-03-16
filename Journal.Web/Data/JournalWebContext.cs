using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Journal.Web.Models.Salat;

namespace Journal.Web.Data
{
    public class JournalWebContext : DbContext
    {
        public JournalWebContext (DbContextOptions<JournalWebContext> options)
            : base(options)
        {
        }

        public DbSet<Journal.Web.Models.Salat.SalatModel> SalatModel { get; set; } = default!;
    }
}
