using Library.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Library.Repository
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("DefaultConnection") { }
        public DbSet<Student> Student { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<StudentBookDetails> StudentBookDetails { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
