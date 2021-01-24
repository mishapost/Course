using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2.Interfaces
{
    public interface IMyClass
    {
        int Field1 { get; set; }
        int Field2 { get; set; }
        int GetResult();
        string ToString();
    }
}
