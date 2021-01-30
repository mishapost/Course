using System;
using System.Threading.Channels;
using HomeWork4.Classes;

namespace HomeWork4
{
    class Program
    {

        private delegate TestDelegateClass MyDelegate();
        
        delegate T GenericDelegate<out T, in TR>(TR value);


        static void Main(string[] args)
        {

            #region Задание 1
            Console.WriteLine("Задание 1");
            MyDelegate delegate2 = () => new TestDelegateClass();

            Console.WriteLine("Вызов делегата через метод");
            delegate2?.Invoke().RunDelegate();


            Console.WriteLine("Вызов делегата из делегата.");
            delegate2?.Invoke().Delegate1?.Invoke();
            //P.S. Если дословно читать ДЗ и вызывать через сокращ. форму,
            // то как проверить на null delegate1?
            //delegate2()?.Delegate1();
            #endregion

            #region Задание 2

            Console.WriteLine();
            Console.WriteLine("Задание 2");
            
            //Пример 1
            GenericDelegate<string,TestDelegateClass> test1 = (TestDelegateClass obj) => obj.ToString();
            Console.WriteLine(test1(new TestDelegateClass()));

            //Пример 2
            GenericDelegate<int, int> test2 = (int a) => a+a;
            Console.WriteLine(test2(10));

            #endregion

            #region Задание 3

            var cat = Cat.GetCat;
            var dog =  new Dog(cat);
            var human = new Human(cat);
            var mouse = new Mouse(cat);

     
            // Запуск события
            cat.CatIsVisible();


            #endregion

        }


    }
}
