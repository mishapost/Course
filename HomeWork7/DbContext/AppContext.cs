
using HomeWork7.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWork7.DbContext
{
    public sealed class AppContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public AppContext()
        {
            // P.S. у меня БД указанной на сервере нету и объектов тоже нет. Для того, чтобы моя апликуха не упала смертью храбрых - принуд. создам ее
            // При выполнении миграции через консоль -- эти методы требуется закоментить, иначе получим ошибку
            Database.EnsureDeleted();   // удаляем бд со старой схемой
            Database.EnsureCreated();   // создаем бд с новой схемой
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = new Connection();
            optionsBuilder.UseSqlServer(connection.GetUserConnectionString());


            // P.S. не хочет в командной строке для созд миграции строку подключения брать из кода  
            //optionsBuilder.UseSqlServer(@"Server=srvtest\sql;Database=HomeWork7;User Id = sa; Password = Dz0K1b");
        }
    }


}
