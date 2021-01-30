using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Classes
{
    public class Human
    {
        private const string Act = "Я человек. Надо погладить котика!";

        public Human(Cat cat)
        {
            cat.WakeUpEvent += ActionForVisibleCat;

        }

        public void ActionForVisibleCat()
        {
            Console.WriteLine(Act);
        }
    }
}
