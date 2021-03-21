using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DepremWebServisi.Model;

namespace DepremWebServisi.DepremDb_Context
{
    public class Db_Context : DbContext
    {
        public Db_Context(DbContextOptions<Db_Context> option) : base(option)
        {

        }

        public DbSet<Deprem> Depremler { get; set; }
        public Deprem Deprem { get; set; }
    }
}
