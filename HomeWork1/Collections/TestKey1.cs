using System;
using HomeWork1.Interface;

namespace HomeWork1.Collections
{
    public class TestKey1 : IKeyInterface
    {
        public TestKey1()
        {
            Id=Guid.NewGuid();
        }

        public Guid Id { get; set;}

        public Guid GetId()
        {
            return Id;
        }
    }
}
