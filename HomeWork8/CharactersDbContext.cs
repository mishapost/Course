using EntityFrameworkCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using HomeWork8.Models;

namespace EntityFrameworkCoreExample
{
    public sealed class CharactersDbContext : DbContext
    {
        public CharactersDbContext()
        {
            Database.EnsureDeleted();   // удаляем бд со старой схемой
            Database.EnsureCreated();   // создаем бд с новой схемой
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Story> Stories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appconfig.json").Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("CharactersConnectionString"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, AuthorName = "Vasya Pupkin"},
                new Author { Id = 2, AuthorName = "Ivan Ivanov" },
                new Author { Id = 3, AuthorName = "Petrovich" });

            modelBuilder.Entity<Story>().HasData(
                new Story { Id = 1, Name = "Foundation", Description = "", AuthorId = 1},
                new Story { Id = 2, Name = "LOTR", Description = "",AuthorId = 2},
                new Story { Id = 3, Name = "Hyperion", Description = "",AuthorId = 3});

            modelBuilder.Entity<Character>().HasData(
                new Character() { Id = 1, FirstName = "Harry", LastName = "Seldon", Gender = true, Age = 35, StoryId = 1 },
                new Character() { Id = 2, FirstName = "Arven", LastName = "Undomiel", Gender = false, Age = 2700, StoryId = 2},
                new Character() { Id = 3, FirstName = "Finn", LastName = "Mertens", Gender = true, Age = 14, StoryId = 3});
        }
    }
}