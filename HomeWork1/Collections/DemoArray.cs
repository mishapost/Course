using System;

namespace HomeWork1.Collections
{
    public class DemoArray
    {
        private int[] _test;

        public DemoArray() => _test = new int[10];


        public void RunTestArray()
        {
            Console.WriteLine("Пример ручного заполнения одномерного массива на 10 элементов");
            Console.WriteLine();
            Console.WriteLine("Заполняю 5-ый элемент массива значением 100");
            _test.SetValue(100, 4);
            Console.WriteLine("Заполняю 10-ый элемент массива значением 200");
            _test[9]=200;

            Console.WriteLine("Результат выполнения выводим циклом for:");

            for (int i = 0; i < _test.Length; i++)
            {
                Console.Write($"{_test[i]} ");
            }


            Console.WriteLine();
            Console.WriteLine("Заполняю массив рандом значениями по индексу в цикле ");
            var rnd = new Random();
            for (int i=0; i < _test.Length; i++)
            {
                _test[i] = rnd.Next(i, _test.Length);
            }

            Output();
            Console.WriteLine();
            Console.WriteLine("Добавим элемент в середину массива. Для чего необходимо 1ым шагом увеличить размер массива на 1 элемент");
            Array.Resize(ref _test,_test.Length+1);
            var midpoint = _test.Length / 2;
            Console.WriteLine("2-ым шагом сдвигаем все элементы вправо");
            for (int i = _test.Length-1; i>midpoint ; i--)
            {
                _test[i] = _test[i - 1];
            }

            Console.WriteLine("3-им шагом вставляю значение 500 в середину");
            _test[midpoint] = 500;
            Output();

            
            Console.WriteLine("Bonus: Сортировка встроенным методом");
            Array.Sort(_test, (x, y) => x.CompareTo(y));
            Output();
            //В обратную сторону, но так скучно Array.Sort(_test, (x, y) => -x.CompareTo(y)); 
            //Хочу вот так, т.к. массив уже отсортирован по возрастанию
            Array.Reverse(_test);
            Output();

            // Локальный метод вывода массива на экран, с помощью цикла ForEach 
            void Output()
            {
                Console.WriteLine();
                Console.WriteLine("Результат выполнения выводим циклом foreach:");
                foreach (var item in _test)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine();
            }

        }

        

    }
}
