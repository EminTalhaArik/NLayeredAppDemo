using Northwind.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAcces.Concrete
{
    class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
