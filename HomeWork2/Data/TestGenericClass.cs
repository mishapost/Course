using System;
using System.Collections.Generic;
using System.Text;
using HomeWork2.Interfaces;

namespace HomeWork2.Data
{
    public class TestGenericClass<T, TR>
        where T : struct
        where TR : IMyClass
    {
        public T FieldT { get; set; }
        private readonly TR _fieldTr;

        public TestGenericClass(TR value2)
        {
           _fieldTr = value2;

        }

        public override string ToString()
        {
            return $"Значение типа T: {FieldT} Значение типа TR: {_fieldTr}";
        }

        public TR GetMyClass()
        {
            return _fieldTr;
        }
    }
}
