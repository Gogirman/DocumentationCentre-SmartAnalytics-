using DataProvider.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataProvider
{
    public class EFDBContext : DbContext
    {
        public DbSet<Docs> Docs { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options)
        {

        }
    }

    public class EFDBContextFactory : IDesignTimeDbContextFactory<EFDBContext>
    {
        public EFDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-M35M6L2\\SQLEXPRESS; Database=DocCenter;Trusted_Connection=True;MultipleActiveResultSets=True", b => b.MigrationsAssembly("DataProvider"));

            return new EFDBContext(optionsBuilder.Options);
        }
    }
}
