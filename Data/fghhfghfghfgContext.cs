using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp2.Models;

namespace fghhfghfghfg.Data
{
    public class fghhfghfghfgContext : DbContext
    {
        public fghhfghfghfgContext (DbContextOptions<fghhfghfghfgContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<WebApp2.Models.Employee> Employee { get; set; }
    }
}
