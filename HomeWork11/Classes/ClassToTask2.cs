using System;
using System.Threading;

namespace HomeWork11.Classes
{
    public class ClassToTask2
    {
        private int _currentThread;
        private readonly object _locker = new object();

        public ClassToTask2()
        {
            _currentThread = 0;
        }

        public void Method1()
        {
            lock (_locker)
            {
                if (_currentThread == 0)
                {
                    _currentThread = 1;
                    Console.WriteLine($"1 метод в потоке с Id: {Thread.CurrentThread.ManagedThreadId}");
                }
            }
        }

        public void Method2()
        {
            lock (_locker)
            {
                if (_currentThread == 1)
                {
                    _currentThread = 2;
                    Console.WriteLine($"2 метод в потоке с Id: {Thread.CurrentThread.ManagedThreadId}");
                }
            }
        }

        public void Method3()
        {
            lock (_locker)
            {
                if (_currentThread == 2)
                {
                    _currentThread = 0;
                    Console.WriteLine($"3 метод в потоке с Id: {Thread.CurrentThread.ManagedThreadId}");
                }
            }
        }

    }
}
