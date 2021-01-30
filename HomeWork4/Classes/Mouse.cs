using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Classes
{
    public class Mouse
    {
        public Mouse(Cat cat)
        {
            cat.WakeUpEvent += ActionForVisibleCat;
        }

        private const string Act = "Я мышь. Пятой точкой чувствую кошачий дух. Надо срочно делать ноги!";

        public void ActionForVisibleCat()
        {
            Console.WriteLine(Act);
        }

    }
}
