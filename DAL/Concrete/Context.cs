using DesignPattern.CQRS.PresentationLayer.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.PresentationLayer.DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2H5V0KB\\SQLEXPRESS;initial catalog=DbCQRS;integrated security=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<University> Universities { get; set; }
    }
}
