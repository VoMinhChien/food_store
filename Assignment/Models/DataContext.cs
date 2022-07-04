using asmC5.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Carts> Carts { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }
        public DbSet<Foods> Foods { get; set; }
        public DbSet<CategoryModels> CategoryModels { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
    }
}
