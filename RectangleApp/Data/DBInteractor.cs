using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RectangleApp.Models;

namespace RectangleApp.Data
{
    public class DBInteractor: DbContext
    {
        public DbSet<Rectangle> rectangles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Rectangle.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var rectanglesForSeed = new List<Rectangle>();
            for (int i = 1; i <= 200; i++)
            {
                rectanglesForSeed.Add(new Rectangle
                {
                    Id = i,
                    x = i,
                    y = i,
                    width = 2,
                    height = 4
                });
            }

            modelBuilder.Entity<Rectangle>().HasData(rectanglesForSeed);
        }
    }
}
