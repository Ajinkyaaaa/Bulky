﻿//whenever we need to register something we need to do it in program.cs
using Bulky.Models;


using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData
                (
                  new Category { Id = 1 ,Name = "Action",Displayorder = 1} ,
                  new Category { Id = 2, Name = "Scifi", Displayorder = 2 },
                  new Category { Id = 3, Name = "Historic", Displayorder = 3 }

                );

        }
    }
}
