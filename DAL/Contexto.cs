using Microsoft.EntityFrameworkCore;
using RegistroBlazor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroBlazor.DAL
{
    public class Contexto : DbContext
    {
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<Prestamos> Prestamos { get; set;}
        public Contexto(){}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source = Data\\GestionRegistroBlazor.db");
            }
        }
    }
}
