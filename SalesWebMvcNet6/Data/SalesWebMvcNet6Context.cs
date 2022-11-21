using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcNet6.Models;

namespace SalesWebMvcNet6.Data
{
    public class SalesWebMvcNet6Context : DbContext
    {
        public SalesWebMvcNet6Context (DbContextOptions<SalesWebMvcNet6Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecord { get; set; } = default!;
    }
}
