using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork9.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class MyAttribute :Attribute
    {
        private int _importance;

        public MyAttribute(int importance)
        {
            _importance = importance;
        }


        public string Description { get; set; }

    }
}
