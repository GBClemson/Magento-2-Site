using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SeedPark_01.Models
{
    public class SeedPark_01Context : DbContext
    {
        public SeedPark_01Context (DbContextOptions<SeedPark_01Context> options)
            : base(options)
        {
        }
        public DbSet<SeedPark_01.Models.Products> Products { get; set; }
    }
}