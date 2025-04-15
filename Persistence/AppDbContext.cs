using Microsoft.EntityFrameworkCore;
using ApiWeb.Domain.Models;
using System.Collections.Generic;

namespace ApiRestDotnet.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Supplier> Suppliers => Set<Supplier>();
    }
}
