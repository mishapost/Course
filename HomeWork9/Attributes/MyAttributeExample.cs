using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork9.Attributes
{
    public class MyAttributeExample
    {
        [MyAttribute(2)]
        private void Method1()
        {
            Console.WriteLine("Я приватный метод");
        }

        [MyAttribute(2,Description = "Ооо")]
        public void Method2()
        {
            Console.WriteLine("Я публичный метод");
        }
    }
}
