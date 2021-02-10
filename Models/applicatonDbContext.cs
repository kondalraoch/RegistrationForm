using Microsoft.EntityFrameworkCore;

namespace RegistrationForm.Models
{
   public class ApplicationDbContext:DbContext  
    {  
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)  
        {  
  
        }  
      public DbSet<Registration> Registration{ get; set; }  
    }  
}