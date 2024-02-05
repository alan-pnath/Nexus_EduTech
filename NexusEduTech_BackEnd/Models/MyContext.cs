using Microsoft.EntityFrameworkCore;
using NexusEduTech_BackEnd.Models;
namespace NexusEduTech_BackEnd.Models
{
    public class MyContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public MyContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public  DbSet<CustomUser> Users { get; set; }
        public DbSet<UserAuthenticate> Login {  get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Examination> Exams { get; set; }   
        public DbSet<Classess> Classesses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Marks> Marks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MyConnection"));
        }

    }
}
