using BuildingProgram.Models;
using Microsoft.EntityFrameworkCore;

namespace BuildingProgram.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User Id=postgres;Password=superadmin;Server=localhost;Port=5432;Database=BuilderProgram");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Land>()
                .Property(x => x.Address)
                .IsRequired();

            modelBuilder.Entity<BuildingObject>()
                .Property(x => x.LandId)
                .IsRequired();

           
        }
        public DbSet<User> Users { get; set; }
        public DbSet<BuildingObject> BuildingObjects { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Land> Lands { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<BuildingCompany> BuildingCompanies { get; set; }
    }
}
