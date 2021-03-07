using blog_template_practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice
{
    public class BlogContext : DbContext
    {
        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogDB_templatetest;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add seed data for Category model:
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Personal Wellness"

                },
                new Category
                {
                    Id = 2,
                    Name = "Food"

                }, new Category
                {
                    Id = 3,
                    Name = "Plans & Dreams"

                }
                );

            // Add seed data for Content model:
            modelBuilder.Entity<Content>().HasData(
                new Content
                {
                    Title = "Once I am Vaccinated",
                    CategoryId = 3,
                    Body = "I want to visit my family in Cincinnati first, and then plan a trip out west, hopefully to Arizona and/or New Mexico",
                    Author = "Shannon",
                    Id = 1,
                    PublishDate = "3/6/2021"

                },
                new Content
                {
                    Title = "Roasted Red Pepper Sauce",
                    CategoryId = 2,
                    Body = "I can't believe this only have 5 ingredients! For best results roast the red peppers yourself. You can put this sauce on anything and everything!",
                    Author = "JP",
                    Id = 2,
                    PublishDate = "2/12/2021"


                },
                new Content
                {
                    Title = "Gratitute List",
                    CategoryId = 1,
                    Body = "My cat, my mom, my sister, WCCI, a warm place to sleep",
                    Author = "Shannon",
                    Id = 3,
                    PublishDate = "1/31/2021"
                },
                new Content
                {
                    Title = "When Winter Is Over",
                    CategoryId = 3,
                    Body = "I'm going on an 8+ mile hike.",
                    Author = "Shannon",
                    Id = 4,
                    PublishDate = "01/01/2021"

                },
                new Content
                {
                    Title = "Creamy Instant Pot Pasta",
                    CategoryId = 2,
                    Body = "So easy and delicious! The perfect vegetarian weeknight meal. Tip: Keep fresh basil out of the fridge as it is cold-sensitive.",
                    Author = "Mary",
                    Id = 5,
                    PublishDate = "03/02/2021"

                },
                new Content
                {
                    Title = "Yoga With Adriene",
                    CategoryId = 1,
                    Body = "Whether you are experienced with yoga or brand new, Yoga With Adriene on YouTube is a dream come true. Namaste!",
                    Author = "BP",
                    Id = 6,
                    PublishDate = "12/05/2020"
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
