using BuildingProgram.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingProgram.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User Id=postgres;Password=superadmin;Server=localhost;Port=5432;Database=BuilderProgram");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<BuildingObject> BuildingObjects { get; set; }
    }
}
