using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mall.Models;

namespace Mall.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Jugadores> Jugadores { get; set; }
        public DbSet<CuentasBancarias> CuentasBancarias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\MallDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jugadores>().HasData(new Jugadores(1));
            modelBuilder.Entity<Jugadores>().HasData(new Jugadores(2));
            modelBuilder.Entity<Jugadores>().HasData(new Jugadores(3));
        }
    }
}
