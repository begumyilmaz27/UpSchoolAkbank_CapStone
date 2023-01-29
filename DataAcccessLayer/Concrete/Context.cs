using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BEGUM;initial catalog=CapstoneProject_DB;integrated security=true");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Highlight> Highlights { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Comment> Comments { get; set; }



    }

}
