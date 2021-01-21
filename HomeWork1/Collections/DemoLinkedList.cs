using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1.Collections
{
    public class DemoLinkedList
    {
        private LinkedList<int> _test;

        public DemoLinkedList() => _test = new LinkedList<int>();

        public void RunTestLinkedList()
        {
            Console.WriteLine("Работа с LinkedList");
            Console.WriteLine("Заполняю значениями в цикле");

            for (int i = 0; i < 10; i++)
            {
                _test.AddLast(i);
            }
            Output();

            Console.WriteLine("Добавлю новый элемент 500 в начало");
            _test.AddFirst(500);
            Output();

            Console.WriteLine("Добавлю новый элемент 1000 в конец");
            _test.AddLast(1000);
            Output();

            Console.WriteLine("Добавлю новый элемент 2000 в середину");
            var middle =_test.Count/ 2;
            var enumerator=0;
            LinkedListNode<int> node=null;
            foreach (var item in _test)
            {
                enumerator++;
                if (enumerator != middle) continue;
                node = _test.Find(item);
                break;
            }

            if (node != null)
            {
                _test.AddAfter(node, 2000);
            }
            else
            {
                _test.AddFirst(2000);
            }
            Output();


            void Output()
            {
                Console.WriteLine();
                Console.WriteLine("Вывод с помощью цикла Foreach");
                foreach (var item in _test)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }

        }

    }
}
