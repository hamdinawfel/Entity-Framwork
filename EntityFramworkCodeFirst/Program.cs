using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EntityFramworkCodeFirst
{

    public class Course
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(2000)]
        public int Description { get; set; }
        public int FullPrice { get; set; }
        public CourseLevel Level { get; set; }

        public Author Author { get; set; }

        public IList<Tag> Tags { get; set; }

    }

    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Course> Courses { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Course> Courses { get; set; }

    }

    public enum CourseLevel
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3
    }
    public class SchoolContext : DbContext
    {
        
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=TN3291358W1;Database=Blog;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            //Property Configurations
            modelBuilder.Entity<Course>()
                .Property(s => s.FullPrice)
                .HasDefaultValue(1200)
                .IsRequired();
        }

    }

    class Program
    {
        static void Main(string[] agrs)
        {

        }
    }
}
