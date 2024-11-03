using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Context : DbContext
    {
        public DbSet<Colectivo> Colectivos { get; set; }
        public DbSet<Pasajero> Pasajeros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Colectivo>().HasKey(co => co.ColectivoId);
            modelBuilder.Entity<Pasajero>().HasKey(pa => pa.PasajeroId);

            modelBuilder.Entity<Colectivo>().HasMany(co => co.Pasajeros).WithMany();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=(localdb)\\MssqllocalDb;Initial Catalog=cfColectivo;Integrated Security=true;");
        }

    }
}
