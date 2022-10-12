using Microsoft.EntityFrameworkCore;
using NORTHWND.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWND.DataAccess.Concrete.EntityFramework
{
    public class NORTHWNDContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB ;Database = NORTHWND;Trusted_Connection=True");
        }
    }

}
