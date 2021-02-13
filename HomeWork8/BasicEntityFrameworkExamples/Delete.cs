using System;
using System.Linq;

namespace EntityFrameworkCoreExample.BasicEntityFrameworkExamples
{
    public static class Delete
    {   
        public static void DeleteCharacter()
        {
            var dbContext = new CharactersDbContext();
            var character = dbContext.Characters.FirstOrDefault(x => x.FirstName == "John");

            dbContext.Characters.Remove(character);

            dbContext.SaveChanges();
            Console.WriteLine("Character deleted");
        }

        //Самостоятельно удалите 6го по счету персонажа
    }
}
