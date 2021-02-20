using System;
using System.Reflection;
using HomeWork10Task3;


namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task2
            var task2 = new HomeWork10Task2.HomeWork10Task2();  // P.S. namespaces и класс специально сделал одинаковыми, чтобы показать как работать в таком случае
            task2.Task2();

            // Task 3
            var task3 = new Task3HomeWork10();
            task3.Serialization();
            task3.DeSerialization();

            // Task 4
            Assembly ass = typeof(Task3HomeWork10).Assembly;
            var types = ass.GetTypes();


            Console.WriteLine("Типы данных в сборке:");
            foreach (var t in types)
            {
                Console.WriteLine(t.Name);
                if (t.Name == "Task3HomeWork10")
                {
                    var fullName = t.FullName;
                    Task3HomeWork10 newInstance = (Task3HomeWork10)ass.CreateInstance(fullName ?? string.Empty);
                    if (newInstance != null)
                        Console.WriteLine($"Экземпляр класса создан через рефлексию. Имя файла из созданного класса: {newInstance.GetFileName()}");
                }
            }

            

          
            
        }
    }
}
