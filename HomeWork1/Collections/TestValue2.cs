using System;
using System.Collections.Generic;
using System.Text;
using HomeWork1.Interface;

namespace HomeWork1.Collections
{
    public class TestValue2 : IValueInterface
    {
        public TestValue2(int value) => MyValue =value.ToString();
        public string MyValue { get; set; }
        

        public string GetCurrentValue()
        {
            return MyValue;
        }

    }
}
