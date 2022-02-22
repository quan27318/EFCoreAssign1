using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models {
    public class StudentDbContext : DbContext {
        public StudentDbContext() { }
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base (options) { }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=ADMIN-PC;Initial Catalog=DBName;Integrated Security=True");
        // }

        public DbSet<Student> Students { get; set; }
        
    }
}