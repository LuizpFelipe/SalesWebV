using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebV.Models.ViewModels;

namespace SalesWebV.Data
{
    public class SalesWebVContext : DbContext
    {
        public SalesWebVContext (DbContextOptions<SalesWebVContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SallesRecord> SallesRecord { get; set; } 
    }
}
