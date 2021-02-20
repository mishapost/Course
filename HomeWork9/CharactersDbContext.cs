using HomeWork9.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HomeWork9
{
    public sealed class CharactersDbContext : DbContext
    {
        public CharactersDbContext()
        { 
            // Для запуска миграции из консоли через команду update-database, этих 2 метода требуется комментировать
            //Database.EnsureDeleted();   // удаляем бд со старой схемой
           // Database.EnsureCreated();   // создаем бд с новой схемой
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
            modelBuilder.Entity<Character>().Property(fn => fn.FirstName).IsRequired();
            modelBuilder.Entity<Character>().Property(fn => fn.FirstName).HasMaxLength(255);
            modelBuilder.Entity<Character>().Property(ln => ln.LastName).IsRequired();
            modelBuilder.Entity<Character>().Property(ln => ln.LastName).HasMaxLength(255);

            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, AuthorCode=1, AuthorName = "Vasya Pupkin"},
                new Author { Id = 2, AuthorCode=2, AuthorName = "Ivan Ivanov" },
                new Author { Id = 3,AuthorCode=3, AuthorName = "Petrovich" });

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