using System;
using EntityFrameworkCoreExample;
using Microsoft.EntityFrameworkCore;

namespace HomeWork8
{
    class Program
    {
        static void Main()
        {
            var context = new CharactersDbContext();
            var characters = context.Characters.Include(x => x.Story.Author);


            foreach (var c in characters)
                Console.WriteLine($"Персонаж: {c.FirstName} " +
                                  $"{c.LastName}  \tИстория: {c.Story?.Name}  \tАвтор истории: {c.Story?.Author?.AuthorName}");
        }

    }
}
