using System;
using System.Collections;

namespace HomeWork1.Collections
{
    public class DemoArrayList
    {
        private readonly ArrayList _test;
        public DemoArrayList() => _test = new ArrayList();

        public void RunTestArrayList()
        {
            Console.WriteLine();
            Console.WriteLine("Добавляю целое число 55 ");
            _test.Add(55);
            Console.WriteLine("Добавляю строку Hello World");
            _test.Add("Hello World");
            Console.WriteLine("Добавляю объект пользовательского типа");
            _test.Add(new TestClass());

            Console.WriteLine("Вывод циклом For:");
            for (int i = 0; i < _test.Count; i++)
            {
                Console.WriteLine(_test[i]);     
            }


            Console.WriteLine();
            Console.WriteLine("Удаляю целое число 55");
            _test.Remove(55);
            Output();

            Console.WriteLine();
            Console.WriteLine("Вставляю новый эл. массива в середину");
            Console.WriteLine("Добавляю число 555. Оно добавится в конец. После чего в цикле двигаю элементы пока не достигну серединки");
            _test.Add(555);

            var midpoint = _test.Count / 2;
            
            for (int i = _test.Count - 1; i > midpoint; i--)
            {
                 var cur = _test[i];
                _test[i] = _test[i - 1];
                _test[i - 1] = cur;
            }
            Output();
        }

        private void Output()
        {
            Console.WriteLine();
            Console.WriteLine("Вывод циклом Foreach:");
            foreach (var t in _test)
            {
                Console.WriteLine(t);
            }
        }

        private class TestClass
        {
     
            public int Test1 { get; set; }
            public decimal Test2 { get; set; }

            public ArrayList Test3 { get; set; }

            public override string ToString()
            {
                return "Hello World From TestClass";
            }
        } 

    }
}
