using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1.Interface
{
    public interface IValueInterface
    {
       string MyValue { get; set; }
       
        string GetCurrentValue();
    }
}
