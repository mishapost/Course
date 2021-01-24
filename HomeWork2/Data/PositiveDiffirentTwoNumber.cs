using System;
using System.Collections.Generic;
using System.Text;
using HomeWork2.Interfaces;

namespace HomeWork2.Data
{
    public class PositiveDiffirentTwoNumber : IMyClass
    {
        public PositiveDiffirentTwoNumber(int field1, int field2)
        {
            Field1 = field1;
            Field2 = field2;
        }

        public int Field1 { get; set;}
        public int Field2 { get; set;}

        public int GetResult()
        {
            if (Field1 > Field2) return Field1 - Field2;
            if (Field2 > Field1) return Field2 - Field1;
            return 0;
        }


        public override string ToString()
        {
            return $"Положит. разница: {GetResult()}";
        }
    }
}
