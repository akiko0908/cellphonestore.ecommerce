using System;
using CellphoneStoreEcommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace CellphoneStoreEcommerce.Data
{
    public class CellphoneStoreContext : DbContext
    {
        public CellphoneStoreContext(DbContextOptions<CellphoneStoreContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}