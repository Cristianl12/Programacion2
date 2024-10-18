using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BoletosApp.Domain.Entities;

namespace BoletosApp.Infraestructure.Dependencies
{
   

    public class DbContextAppInfrastructure : DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Asiento> Asientos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("your_connection_string");
        }
    }
}
