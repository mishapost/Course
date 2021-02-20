using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttributeFoHomeWork10
{
    [MyAttribute(Description = "Я тестовый класс")]
    public class MyAttributeExample
    {
        public string Other;
        
        [MyAttribute(1)]
        [MyAttribute(Description = "приватный метод")]
        private void Method1()
        {
            Console.WriteLine("Я приватный метод");
        }

        [MyAttribute(2, Description = "Ооо")]
        public void Method2()
        {
            Console.WriteLine("Я публичный метод");
        }
    }
}
