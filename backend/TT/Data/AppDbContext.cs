using Microsoft.EntityFrameworkCore;
using TT.Entities;

namespace TT.Data
{
    public class AppDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=ASUS\\SERVER2;Database=thuctap;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public DbSet<Phattu> phattus { get; set; }
        public DbSet<Chuas> chuas { get; set; }
        public DbSet<Daotrangs> daotrangs { get; set; }
        public DbSet<Dondangkis> dondangkis { get;set; }
        public DbSet<Kieuthanhviens> Kieuthanhviens { get; set; }
        public DbSet<Phattudaotrangs> phattudaotrangs { get;set; }
        public DbSet<Token> tokens { get; set; }
    }
}
