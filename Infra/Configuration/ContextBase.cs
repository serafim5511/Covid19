using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infra.Configuration
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        public DbSet<Cache> Cache { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //local
                //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Covid19;Integrated Security=False;Encrypt=False;TrustServerCertificate=False");
                optionsBuilder.UseSqlServer(@"Server=tcp:covid19projeto.database.windows.net,1433;Initial Catalog=Covid;Persist Security Info=False;User ID=covid19;Password=123456qW@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                base.OnConfiguring(optionsBuilder);
            }
        }

    }
}
