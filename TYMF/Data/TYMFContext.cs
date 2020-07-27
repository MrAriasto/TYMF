using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TYMF.Models;

namespace TYMF.Data
{
    public class TYMFContext : DbContext
    {
        public TYMFContext (DbContextOptions<TYMFContext> options)
            : base(options)
        {
        }

        public DbSet<TYMF.Models.Invoioce> Invoioce { get; set; }
    }
}
