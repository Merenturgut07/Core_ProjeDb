using Core_Proje_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje_Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FCK5R8M\\SQLEXPRESS;database=CoreProjeDb2;integrated security=true");
        }

        public DbSet<Category> categories { get; set; }
    }
}
