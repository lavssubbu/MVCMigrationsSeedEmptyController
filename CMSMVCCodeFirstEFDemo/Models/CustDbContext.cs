using Microsoft.EntityFrameworkCore;
using CMSMVCCodeFirstEFDemo.Models;

namespace CMSMVCCodeFirstEFDemo.Models
{
    public class CustDbContext : DbContext
    {
        //DbSet & Constructor
        //DbSet for customer
        public DbSet<Customer> customers {  get; set; }

        //Initializing CustomerDbContext
        public CustDbContext(DbContextOptions<CustDbContext> options) : base(options) 
        { }

        //Seeding of data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                 .HasData(new Customer() { custId = 1, custName = "Reena", custLoc = "Chennai", dateofbirth = new DateTime(2000, 7, 2) },
                new Customer() { custId = 2, custName = "Riyaz", custLoc = "Pune", dateofbirth = new DateTime(2001, 7, 2) });

            modelBuilder.Entity<Order>()
                .HasData(new Order() { OrderId = 1, ProductName = "Laptop", OrderDate = new DateTime(2024, 12, 10), CustId = 2 });

            modelBuilder.Entity<Order>()
                .Property(p => p.CustAmount)
                .HasColumnType("decimal(10,2)");
        }
        public DbSet<CMSMVCCodeFirstEFDemo.Models.Order> Order { get; set; } = default!;


    }
}
