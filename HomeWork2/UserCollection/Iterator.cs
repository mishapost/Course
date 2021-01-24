using System.Collections;
using System.Collections.Generic;
using HomeWork2.Interfaces;

namespace HomeWork2.UserCollection
{
    public class MyIterator<T> : IEnumerator<T> where T:IMyClass 
    {
        private readonly List<T> _myCollection;
        private int _position = -1;

        public MyIterator(List<T> myCollection)
        {
            this._myCollection = myCollection;
        }

        public T Current => _myCollection[_position];

        object IEnumerator.Current => Current;

        public void Dispose() {}

        public bool MoveNext()
        {
            return ++_position < _myCollection.Count;
        }

        public void Reset()
        {
            _position = -1;
        }


    }
 
}