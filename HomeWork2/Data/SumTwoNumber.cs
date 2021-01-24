using System;
using System.Collections.Generic;
using System.Text;
using HomeWork2.Interfaces;

namespace HomeWork2.Data
{
    public class SumTwoNumber : IMyClass
    {
        public SumTwoNumber(int field1, int field2)
        {
            Field1 = field1;
            Field2 = field2;
        }


        public int Field1 { get; set; }
        public int Field2 { get; set; }

        public int GetResult()
        {
            return Field1+Field2;
        }

        public override string ToString()
        {
            return $"Сумма чисел: {GetResult()}";
        }
    }
}
