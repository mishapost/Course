using System;
using System.Linq;
using System.Threading.Channels;
using HomeWork6.Repository;
using LINQ.HelpMaterial;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {


            // Задание 1
            var personages = CharactersRepository.GetCharacters();

            Console.WriteLine("Task1. Из коллекции персонажей делаю коллекцию с анонимным типом");

            var persons = personages.Select(character => 
                new {
                    PersonDescription =
                        $" FirstName: {character.FirstName}"+
                        $" LastName: {character.LastName} "+
                        $" Gender: {character.Gender}"+
                        $" Age: {character.Age}"+
                        $" StoryId: {character.StoryId}"+
                        $" StoryName: {character.StoryName}"
                    });

            foreach (var item in persons)
            {
                Console.WriteLine(item.PersonDescription);

            }


            // Задание 2
            Console.WriteLine();
            Console.WriteLine("Задание 2. LEFT JOIN");
            var stories = StoriesRepository.GetStories();
            var leftjoin = personages.GroupJoin(stories,
                character => character.StoryId,
                story => story.Id,
                (character, stories) => new {character,stories})
            .SelectMany(groupJoin => groupJoin.stories.DefaultIfEmpty(),
                (groupJoin, subStory) =>

                       new CharacterJoinStory()
                       {
                           FirstName = groupJoin.character.FirstName,
                           LastName = groupJoin.character.LastName,
                           Gender = groupJoin.character.Gender,
                           Age = groupJoin.character.Age,
                           StoryName = subStory?.Name ?? "O-o-o-ps",
                           StoryDescription = subStory?.Description ?? "O-o-o-ps"
                       })
            .ToList();


            leftjoin.ForEach(Console.WriteLine);
        }
                                      

    }

    
}
