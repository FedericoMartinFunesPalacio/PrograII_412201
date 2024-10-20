using Microsoft.EntityFrameworkCore;
using Problema2_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Data
{
    public class WebDbContext : DbContext
    {
        //CONSTRUCTORES
        public WebDbContext(DbContextOptions<WebDbContext> opciones) : base(opciones)
        {

        }

        //ATRIBUTOS Y PROPS
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Turnos> Turnos { get; set; }
        public DbSet<DetalleTurnos> DetalleTurnos { get; set; }

        //METODO
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
