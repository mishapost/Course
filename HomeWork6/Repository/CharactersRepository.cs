

using System.Collections.Generic;

namespace HomeWork6.Repository
{
    public static class CharactersRepository
    {
        public static IEnumerable<Character> GetCharacters()
        {
            var characters = new List<Character>();

            characters.Add(new Character("Finn", "Mertens", true, 14, 1, "Fairytail of the lost needle"));
            characters.Add(new Character("Philip", "Fry", true, 25, 1, "Fairytail of the lost needle"));
            characters.Add(new Character("Arwen", "Menethil", false, 2700, 1, "Fairytail of the lost needle"));
            characters.Add(new Character("Audrey", "Hepburn", false, 29, 1, "Fairytail of the lost needle"));
            characters.Add(new Character("John", "Wick", true, 42, 1, "Fairytail of the lost needle"));
            characters.Add(new Character("Anakin", "Skywalker", true, 29, 2, "Foundation"));
            characters.Add(new Character("Princess", "Bubblegum", false, 827, 4, ""));
            characters.Add(new Character("Svetlana", "Sokolova", false, 45, 4, ""));
            characters.Add(new Character("Varian", "Wrynn", true, 42, 3, "Cool story, Bob"));

            return characters;
        }
    }
}