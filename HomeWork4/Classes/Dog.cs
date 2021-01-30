using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Classes
{
    public class Dog
    {
        public Dog(Cat cat)
        {
            cat.WakeUpEvent += ActionForVisibleCat;
        }

        private const string Act = "Я злой пес. Догнать и порвать кота!";
       
       
        public void ActionForVisibleCat()
        {
            Console.WriteLine(Act);
        }

    }
}
