using EntityFrameworkCoreExample.Models;
using System.Collections.Generic;

namespace EntityFrameworkCoreExample
{
    public static class CharactersRepository 
    {
        public static List<Character> GetCharacters()
        {
            var characters = new List<Character>();

            characters.Add(new Character() { FirstName = "Finn", LastName = "Mertens", Gender = true, Age = 14 });
            characters.Add(new Character() { FirstName = "Philip", LastName = "Fry", Gender = true, Age = 25 });
            characters.Add(new Character() { FirstName = "Arven", LastName = "Undomiel", Gender = false, Age = 2700 });
            characters.Add(new Character() { FirstName = "Audrey", LastName = "Hepburn", Gender = false, Age = 29 });
            characters.Add(new Character() { FirstName = "John", LastName = "Wick", Gender = true, Age = 42 });
            characters.Add(new Character() { FirstName = "Anakin", LastName = "Skywalker", Gender = true, Age = 29 });
            characters.Add(new Character() { FirstName = "Princess", LastName = "Bubblegum", Gender = false, Age = 827 });
            characters.Add(new Character() { FirstName = "Svetlana", LastName = "Sokolova", Gender = false, Age = 45 });
            characters.Add(new Character() { FirstName = "Varian", LastName = "Wrynn", Gender = true, Age = 42 });
            characters.Add(new Character() { FirstName = "Harry", LastName = "Seldon", Gender = true, Age = 35 });

            return characters;
        }

    }
}