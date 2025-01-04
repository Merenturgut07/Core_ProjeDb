using EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
    public class Context:IdentityDbContext<WriterUser,WriterRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FCK5R8M\\SQLEXPRESS;database=CoreProjeDb;integrated security=true");
        }
        public DbSet<About> abouts { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<Feature> features { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Portfolio> portfolios { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Deneme> denemes { get; set; }
        public DbSet<Announcement> announcements { get; set; }
        public DbSet<WriterMessage> writerMessages { get; set; }
    }
}
