using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.Models
{
    public class StockContext: DbContext
    {
        public StockContext(DbContextOptions<StockContext> options): base(options)
        {

        }

        public DbSet<Stock> StockItems { get; set; }
    }
}
