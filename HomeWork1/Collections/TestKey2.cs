using System;
using System.Collections.Generic;
using System.Text;
using HomeWork1.Interface;

namespace HomeWork1.Collections
{
    class TestKey2 : IKeyInterface
    {
        public TestKey2(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
        public Guid GetId()
        {
            return Id;
        }
    }
}
