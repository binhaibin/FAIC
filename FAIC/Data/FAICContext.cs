using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FAIC.Models;

namespace FAIC.Models
{
    public class FAICContext : DbContext
    {
        public FAICContext (DbContextOptions<FAICContext> options)
            : base(options)
        {
        }

        public DbSet<FAIC.Models.Product> Product { get; set; }

        public DbSet<FAIC.Models.Category> Category { get; set; }
    }
}
