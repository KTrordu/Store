using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DAL.AppDbContext
{
    public class AppDbContext : DbContext
    {
        AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<StoreApp.Domain.Entities.Product> Products { get; set; }
    }
}
