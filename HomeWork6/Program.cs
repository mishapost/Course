using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Channels;
using HomeWork6.Context;
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
            Console.WriteLine("Task 2. LEFT JOIN");
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


            // Задание 3
            Console.WriteLine();
            Console.WriteLine("Task 3. DATABASE");

            var connectionBuilder = new Connection();
            var connectionString = connectionBuilder.GetUserConnectionString();

            Console.WriteLine("Из параметров App.Config собрал строку подключения:");
            Console.WriteLine(connectionString);

            using (var adoConnection = new SqlConnection(connectionString))
            {
               
                try
                {
                    adoConnection.Open();
                    Console.WriteLine("Подключение установлено");
                    Console.WriteLine("Создаю таблицу Stories");

                    var sqlText =
                        "CREATE TABLE [dbo].[Stories]([Id][int] IDENTITY(1,1) NOT NULL,[NameStory] [varchar](50) NOT NULL,[IndexStory] [int] NOT NULL," +
                        "CONSTRAINT[PK_Stories] PRIMARY KEY CLUSTERED([Id] ASC) WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF," +
                        "ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]) ON[PRIMARY]";
                    SqlCommandExecute(sqlText, adoConnection);
                    Console.WriteLine("В таблицу Stories вставляю значения");
                    sqlText =
                        "Insert into Stories(NameStory,IndexStory) VALUES('ИСТОРИЯ1',1),('ИСТОРИЯ2',2),('ИСТОРИЯ3',15)";
                    SqlCommandExecute(sqlText, adoConnection);

                    Console.WriteLine("Вывожу содержимое таблицы Stories");
                    sqlText = "SELECT NameStory,IndexStory FROM Stories";
                    var command = new SqlCommand(sqlText, adoConnection);
                    try
                    {
                        using (var sqlReader = command.ExecuteReader())
                        {
                            while (sqlReader.Read())
                            {
                                Console.WriteLine($"Field1: {sqlReader[0]}, \tField2: {sqlReader[1]}");
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Ошибка: {e.GetBaseException().Message}");
                    }
                    finally
                    {
                        command.Dispose();
                    }


                }
                catch
                {
                    Console.WriteLine("Подключение к БД не установлено");
                }

            }

        }

        private static void SqlCommandExecute(string sqlText, SqlConnection con)
        {
            var sqlCommand = new SqlCommand(sqlText, con);
            try
            {
                sqlCommand.ExecuteNonQuery();
                Console.WriteLine("SQL команда успешно выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка выполнения SQL команды: {e.GetBaseException().Message}");
            }
            finally
            {
                sqlCommand.Dispose();
            }
        }


    }

    
}
