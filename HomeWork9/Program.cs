using System;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using HomeWork9.Attributes;

namespace HomeWork9
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

            // Задание 3
            var filename = Environment.CurrentDirectory + @"\Test\Test.txt";
            FileInfo fileInfo = new FileInfo(filename);
            try
            {
                fileInfo.Create();
            }
            catch (Exception e)
            {
                var directory = fileInfo.DirectoryName;
                if (!Directory.Exists(directory))
                {
                  
                  Directory.CreateDirectory(directory);
                  fileInfo.Create();
                }
                else Console.WriteLine($"Ошибка: {e.GetBaseException().Message}");
            }

            // Задание 4
            var attr = new MyAttributeExample();
            var myMethods = attr.GetType().GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

              
            foreach (var method in myMethods)
             foreach (var attributeData in method.CustomAttributes)
                  Console.WriteLine($"Метод: {method} имеет атрибут: {attributeData}");

        }
    }
}
