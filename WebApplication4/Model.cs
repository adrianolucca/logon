using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WebApplication4
{
    public class BlogContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Blog> Blogs { get; set; }

        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //  optionsBuilder.UseSqlServer(@"Data Source=ADRIANO-PC\SQLEXPRESS;Initial Catalog=makeMagic;Integrated Security=True;");
        }
      
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public int BlogTipoId { get; set; }
        public BlogTipo BlogTipo { get; set; }
    }
    public class BlogTipo
    {
        public int BlogTipoId { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }

    }
    public class ApplicationUser : IdentityUser
    {
    }

    public static class UserRoles
    {
        public const string Admin = "Admin";
        public const string User = "User";
    }

    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

       
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string token { get; set; }

    }

    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
    public class Response
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

}