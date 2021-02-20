using System;

namespace MyAttributeFoHomeWork10
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class MyAttribute : Attribute
    {
        private int _importance;

        public MyAttribute()
        {
            
        }

        public MyAttribute(int importance)
        {
            _importance = importance;
        }

        public string Description { get; set; }
    }
}
