using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using LivrariaDoPepeu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaDoPepeu.Data
{
    public class LDPContext : IdentityDbContext 
    {
        public LDPContext(DbContextOptions<LDPContext> options) : base(options) { }
        public DbSet<Product> Product { get; set; }
    }
}
