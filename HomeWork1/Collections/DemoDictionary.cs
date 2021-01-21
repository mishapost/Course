using System;
using System.Collections.Generic;
using HomeWork1.Interface;

namespace HomeWork1.Collections
{
    public class DemoDictionary
    {
        private Dictionary<IKeyInterface, IValueInterface> _test;

        public DemoDictionary()=> _test = new Dictionary<IKeyInterface, IValueInterface>();


        public void RunTestDictionary()
        {
            Console.WriteLine("Добавляю элементы в словарь");
            _test.Add(new TestKey1(), new TestValue1(123));
            _test.Add(new TestKey1(), new TestValue2(456));
            _test.Add(new TestKey2(Guid.NewGuid()), new TestValue1(789));
            _test.Add(new TestKey2(Guid.NewGuid()), new TestValue2(012));
            Output();

            var key = new TestKey1();
            var value = new TestValue1(2);

            Console.WriteLine("Добавляю в словарь еще одну пару");
            _test.Add(key,value);
            Output();
            Console.WriteLine("При попытке добавить значение с имеющимся ключом - будет Exception");

            try
            {
                _test.Add(key, value);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.GetBaseException().Message} Попытка добавить значение с ключом: {key.GetId()}");
            }

            Console.WriteLine("Избежать ошибку можно используя метод ContainsKey, но при этом удалить пред. значение");
            if (_test.ContainsKey(key))
            {
                _test.Remove(key);
                _test.Add(key,new TestValue1(888888888));
            }
            Output();



            void Output()
            {
                Console.WriteLine();
                Console.WriteLine("Вывод циклом Foreach");
                foreach (var item in _test)
                {
                    Console.WriteLine($"Ключ: {item.Key.GetId()}, Значение: {item.Value.GetCurrentValue()}");
                }
            }

        }

    }

   
}
