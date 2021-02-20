using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;

namespace HomeWork10Task3
{
    public class Task3HomeWork10
    {
        private List<MyJsonModel> _collection;
        private const string FileName = "test.json";
       
        public void Serialization()
        {
            _collection = new List<MyJsonModel>();
            _collection.Add(new MyJsonModel{Name = "Вася", Age = 25, IsMen = true});
            _collection.Add(new MyJsonModel { Name = "Петя", Age = 33, IsMen = true });
            _collection.Add(new MyJsonModel { Name = "Полина", Age = 20, IsMen = false });

            // сериализация
            var jsonData = JsonSerializer.Serialize(_collection);
            // Запись в файл
            using (StreamWriter w = new StreamWriter(FileName, false))
            {
                w.Write(jsonData);
                Console.WriteLine($"Данные сериализованы и записаны в файл {FileName}");
            }

        }

        public void DeSerialization()
        {
            try
            {

                var jsonData = "";
                using (StreamReader r = new StreamReader(FileName))
                {
                    jsonData = r.ReadToEnd();
                }
                // десериализация

                _collection = JsonSerializer.Deserialize<List<MyJsonModel>>(jsonData);

                Console.WriteLine($"Данные прочитаны из файла {FileName}. Вывод на экран:");
                foreach (var item in _collection)
                {
                    Console.WriteLine($"Name: {item.Name}  Age: {item.Age} IsMen: {item.IsMen}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.GetBaseException().Message}");
            }
        }

        public string GetFileName()
        {
            return FileName;
        }

    }

    public class MyJsonModel
    {
        public string  Name { get; set; }
        public int Age { get; set; }
        public bool IsMen { get; set; }

    }
}
