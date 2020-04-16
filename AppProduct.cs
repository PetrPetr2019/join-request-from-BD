using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ProductCost
{
    public class AppProduct:DbContext
    {
        public virtual DbSet<Product>Products { get; set; }
        public virtual DbSet<Prices>Priceses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = (localdb)\\MSSQLLocalDB; Database = ProductDB200; Trusted_Connection = True");
        }
    }
}
