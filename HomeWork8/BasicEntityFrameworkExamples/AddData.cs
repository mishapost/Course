using System;

namespace EntityFrameworkCoreExample.BasicEntityFrameworkExamples
{
    public static class AddData
    {
        public static void AddCharactersToDb()
        {
            var dbContext = new CharactersDbContext();
            var characters = CharactersRepository.GetCharacters();
            foreach (var character in characters)
            {
                dbContext.Characters.Add(character);
            }

            dbContext.SaveChanges();
            Console.WriteLine("Characters added");
        }

        //Самостоятельно создайте базу и таблицу Characters с помощью Code First 
        //добавьте персонажей в БД, подключите для этого пример EntityFrameworkExample 
        //как библиотеку и используйте CharactersService для получения персонажей
    }
}