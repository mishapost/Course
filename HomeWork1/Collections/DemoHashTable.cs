using System;
using System.Collections;

namespace HomeWork1.Collections
{
    public class DemoHashTable
    {
        private Hashtable _test;
        public DemoHashTable() => _test = new Hashtable();

        public void RunTestHashTable()
        {
            Console.WriteLine("Добавляю значения");
            _test.Add(1,"Вася");
            _test.Add(2, "Петя");
            _test.Add(3, "Коля");

            Output();

            Console.WriteLine("Удаляем элемент из хеш таблицы по ключу 2");
            _test.Remove(2);
            Output();

            
            Console.WriteLine($"Меняю значение элемента по ключу 1 с {_test[1]} на Вася Пупкин");
            _test[1] = "Вася Пупкин";
            Output();
            

            Console.WriteLine("Получить ключ по значению Вася Пупкин");
            foreach (DictionaryEntry item in _test)
            {
                if ((string)item.Value == "Вася Пупкин")
                {
                    Console.WriteLine($"Значение: Вася Пупкин Ключ:{item.Key}");
                    break;
                }
                
            }

            
            Console.WriteLine($"Хеш-код:{_test.GetHashCode()}");



            void Output()
            {
                Console.WriteLine();
                Console.WriteLine("Вывод на экран");
                foreach (DictionaryEntry item in _test)
                {
                    Console.WriteLine($"Ключ: {item.Key} Значение: {item.Value}");
                }
            }





        }


    }
}
