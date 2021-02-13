using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EntityFrameworkCoreExample.BasicEntityFrameworkExamples
{
    public static class GetData
    {
        public static void GetCharactersFromDb()
        {
            var dbContext = new CharactersDbContext();            

            foreach (var c in dbContext.Characters)            
                Console.WriteLine($"Id: {c.Id},  \tFirstName: {c.FirstName}  " +
                    $"\tLastName: {c.LastName}  \tGender: {c.Gender}  \tAge: {c.Age}");                     
        }

        public static void GetDependentData()
        {
            var dbContext = new CharactersDbContext();
            var characters = dbContext.Characters.Include(x => x.Story);

            foreach (var c in characters)
                Console.WriteLine($"Id: {c.Id},  \tFirstName: {c.FirstName}  " +
                    $"\tLastName: {c.LastName}  \tGender: {c.Gender}  \tAge: {c.Age}");

            foreach (var c in characters)
                Console.WriteLine($"Id: {c.Story.Name},  \tFirstName: {c.FirstName}  " +
                    $"\tLastName: {c.LastName}  \tGender: {c.Gender}  \tAge: {c.Age}");
        }
    }
}