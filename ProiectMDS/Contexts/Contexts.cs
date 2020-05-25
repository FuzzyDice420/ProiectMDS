using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectMDS.Models;

namespace ProiectMDS.Contexts
{
    public class Context : DbContext
    {
        public DbSet<Component> Components { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShopStock> ShopStocks { get; set; }

        public DbSet<ComponentCart> ComponentCarts { get; set; }


        public static bool isMigration = true;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (isMigration)
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-OQT7DE1\SQLEXPRESS;Database=DBProiectMDS2;Trusted_Connection=true;");
        }
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }

    }

}