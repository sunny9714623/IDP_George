using Microsoft.EntityFrameworkCore;
using System;
using WEB.Domain.Entity.Entity;

namespace WEB.Infrusture
{
    public class WebDBContext : DbContext
    {
        public WebDBContext(DbContextOptions<WebDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
