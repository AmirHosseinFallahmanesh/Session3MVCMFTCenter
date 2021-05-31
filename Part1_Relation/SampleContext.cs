using Microsoft.EntityFrameworkCore;

namespace Part1_Relation
{
    public class SampleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.;Database=DemoSession3;Trusted_Connection=True;");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBiography> AuthorBiographies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookCategory> bookCategories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
