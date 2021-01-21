using System;
using System.Collections;

namespace HomeWork1.Collections
{
    public class DemoQueue
    {

        private readonly Queue _test;
        public DemoQueue() => _test = new Queue();

        public void RunTestQueue()
        {
            Generate();

            Console.WriteLine("Вывод циклом For. Добраться до каждого элемента только через удаление посл. и помещение его в начало");
            for (int i = 0; i < _test.Count; i++)
            {
                var element = _test.Dequeue();
                Console.WriteLine(element);
                _test.Enqueue(element);
            }

            Console.WriteLine();
            Console.WriteLine("Вывод ForEach");
            foreach (var t in _test)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("Метод Peek --- возвращает  без удаления последний элемент (т.е. тот кто вошел первым)");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(_test.Peek());
            }
        }
   

        private void Generate()
        {
            Console.WriteLine();
            Console.WriteLine("Добавляю целое число 55 ");
            _test.Enqueue(55);
            Console.WriteLine("Добавляю объект");
            _test.Enqueue(new object());
            Console.WriteLine("Добавляю строку Hello World");
            _test.Enqueue("Hello World");
        }

    }
}
