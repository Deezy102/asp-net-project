using Microsoft.EntityFrameworkCore;

namespace asp_net_project.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User 
                { 
                    Id = 1, 
                    Login = "admin", 
                    PasswordHash = User.HashPassword("admin"), 
                    Role = Role.Admin 
                },
                new User
                {
                    Id = 2,
                    Login = "user",
                    PasswordHash = User.HashPassword("user"),
                    Role = Role.User
                }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "qwe",
                    Author = "zxc",
                    ReleaseDate = new(2022, 11, 23),
                    Genre = "ewq"
                }
            );
        }
    }
}
