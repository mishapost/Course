using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace HomeWork4.Classes

{   
    

    public class TestDelegateClass
    {

        
        public Action Delegate1;   //P.S. Мне через Action удобней (я к нему привык, меньше писанины, хотя знаю что до его мы еще не дошли)
                                   // В Program Func использовать не буду, сделаю для примера через delegate
        public TestDelegateClass()
        {
            Delegate1 = new Action(HelloWorld);
            Delegate1 += HelloPeople;

        }

        public void RunDelegate()
        {
            Delegate1?.Invoke();
        }

        private void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        private void HelloPeople()=> Console.WriteLine("Hello People!");

        public override string ToString()
        {
            return "Я тестовый класс для демонстрации работы делегатов :-)";
        }
    }
}
