using System;
using HomeWork1.Collections;

namespace HomeWork1
{
    class Program
    {
        private static void Main()
        {
            #region Array
            Console.WriteLine("Пример работы с массивом:");
            var testArray=new DemoArray();
            testArray.RunTestArray();
            Ending("Array");
            #endregion

            #region ArrayList
            Console.WriteLine("Пример работы с ArrayList:");
            var testArrayList = new DemoArrayList();
            testArrayList.RunTestArrayList();
            Ending("ArrayList");
            #endregion

            #region Stack
            Console.WriteLine("Пример работы со Stack:");
            var testStack = new DemoStack();
            testStack.RunTestStack();
            Ending("Stack");
            #endregion

            #region Queue
            Console.WriteLine("Пример работы с очередью:");
            var testQueue = new DemoQueue();
            testQueue.RunTestQueue();
            Ending("Queue");

            #endregion

            #region Dictionary
            Console.WriteLine("Пример работы со словарем:");
            var testDict = new DemoDictionary();
            testDict.RunTestDictionary();
            Ending("Dictionary");
            #endregion

            #region HashTable
            Console.WriteLine("Пример работы с хеш-таблицей:");
            var testHash = new DemoHashTable();
            testHash.RunTestHashTable();
            Ending("HashTable");
            #endregion

            #region LinkedList
            Console.WriteLine("Пример работы с LinkedList:");
            var testLinkedList = new DemoLinkedList();
            testLinkedList.RunTestLinkedList();
            Ending("LinkedList");
            #endregion

            static void Ending(string text)
            {
                Console.WriteLine();
                Console.WriteLine($"-- Демонстрация работы с {text} закончена --. Нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
