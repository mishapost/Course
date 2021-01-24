using System;
using HomeWork2.Data;
using HomeWork2.Interfaces;
using HomeWork2.UserCollection;

namespace HomeWork2
{
    class Program
    {
        static void Main()
        {

            #region Создание коллекции и вывод ее на экран циклом Foreach с указанием моего пользовательского типа 
            Console.WriteLine("Добавляю в мою коллекцию элементы");
            var collection = new MyCollection<IMyClass>
            {
                new SumTwoNumber(23, 56),
                new SumTwoNumber(55, 90),
                new SumTwoNumber(155, 190),
                new PositiveDiffirentTwoNumber(45, 190),
                new PositiveDiffirentTwoNumber(555, 678)
            };

            // При указании типа в Foreach в итераторе обращаюсь к методу T Current и возвращ. свой тип данных 
            foreach (IMyClass item in collection)
            {
                Console.WriteLine($"В коллекции элемент со значениями: {item.Field1} и {item.Field2}.  {item}");
            }
            #endregion

            DeleteItemFromCollection(null);

            #region Добавление в ранее созданную коллекцию 1 дополнительного элемента и вывод ее на экран циклом Foreach с применением распаковки 
            var testElement = new PositiveDiffirentTwoNumber(-200, 80);
            Console.WriteLine();
            Console.WriteLine($"Добавляю еще один элемент в коллекцию со значениями: {testElement.Field1} и {testElement.Field2}");
            collection.Add(testElement);

            // При указании var в Foreach в итераторе обращаюсь к методу Object Current и здесь делаю Unboxing. 
            foreach (var item in collection)
            {
                Console.WriteLine($"В коллекции элементы со значениями: { ((IMyClass)item).Field1 } и {((IMyClass)item).Field2}. {(IMyClass)item}");
            }
            #endregion

            #region Удаление элемента и вывод на экран с помощью переопределенного метода ToString
            Console.WriteLine();
            Console.WriteLine("Удаляю только что добавленный элемент из коллекции");
            DeleteItemFromCollection(testElement);

            Console.WriteLine();
            // При указании var в Foreach в итераторе обращаюсь к методу Object Current и здесь надо Unboxing делать. В данном примере я переопределил ToString 
            foreach (var item in collection)
            {
                Console.WriteLine($"{item}");
            }
            #endregion

            #region Задание 2. Работа с Generic

            Console.WriteLine();
            Console.WriteLine("Пример работы с Generic");
            var testGeneric = new TestGenericClass<int, IMyClass>(testElement)
            {
                FieldT = 5555
            };
            Console.WriteLine($"Generic: {testGeneric} ");
            Console.WriteLine($"MyClass: {testGeneric.GetMyClass()}");
            #endregion

            Console.ReadKey();

            void DeleteItemFromCollection(IMyClass elem)
            {
                //Попытка удаления элемента из коллекции
                try
                {
                    Console.WriteLine();
                    Console.WriteLine($"Сейчас в коллекции {collection.Count()} элементов. Пробую удалить");
                    collection.Delete(elem);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка: {e.GetBaseException().Message}");

                }

            }

        }


    }
}
