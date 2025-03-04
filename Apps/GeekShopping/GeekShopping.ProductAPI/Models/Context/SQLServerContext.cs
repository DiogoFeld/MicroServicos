using GeekShopping.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Models.Context
{
    public class SQLServerContext : DbContext
    {

        public SQLServerContext() { }
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options) { }


        public DbSet<Product> Products { get; set; }
    }
}
