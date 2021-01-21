using System;
using System.Collections;

namespace HomeWork1.Collections
{
    public class DemoStack
    {
        private readonly Stack _test;

        public DemoStack() => _test = new Stack();

        public void RunTestStack()
        {
            Generate();

            Console.WriteLine("Вывод циклом For. Добраться до каждого элемента только через удаление верхнего");

            // т.к. элементы будем удалять надо переменная с исходным к-вом
            var count = _test.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(_test.Pop());
            }

            Console.WriteLine($"Стек пустой. Кол-во элементов:{_test.Count}");
            Generate();

            Console.WriteLine();
            Console.WriteLine("Вывод foreach.");
            foreach (var t in _test)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine($"Стек не пустой. Кол-во элементов:{_test.Count}");

            Console.WriteLine();
            Console.WriteLine("Демонстрация Peek. Запускаю метод в цикле 5 раз и убеждаюсь в том, что всегда мне приходит один и тот же объект.(Тот который добавлен посл.)");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(_test.Peek());
            }
        }

        private void Generate()
        {
            Console.WriteLine();
            Console.WriteLine("Добавляю целое число 55 ");
            _test.Push(55);
            Console.WriteLine("Добавляю объект");
            _test.Push(new object());
            Console.WriteLine("Добавляю строку Hello World");
            _test.Push("Hello World");

        }


    }

}
