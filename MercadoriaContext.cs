using System;
using Microsoft.EntityFrameworkCore;

namespace MercadoriasAlura
{
    internal class MercadoriaContext : DbContext
    {
        public DbSet<Mercadorias> Mercadoria { get; set; }
        public DbSet<Compra> Compras { get; set; }
    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MercadoDB;Trusted_Connection=true;");
        }
    }
}