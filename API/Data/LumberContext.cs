using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class LumberContext : DbContext
    {
        public LumberContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Lumber> Lumbers { get; set; }
    }
}