using System;
using System.Threading;
using HomeWork11.Classes;

namespace HomeWork11
{
    class Program
    {
        private static readonly BankAccount TestBankAccount = new BankAccount();
        private static readonly ClassToTask2 ClassToTask2 = new ClassToTask2();
        static void Main()
        {
            Console.WriteLine("");
            Console.WriteLine("Задание №3");
            if (System.Diagnostics.Process
                .GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                Console.WriteLine("Одна копия этого приложения уже выполняется!!!");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Запущена первая копия приложения!");
            }



            Console.WriteLine("Задание №1");
            var threads = new Thread[5];
            for (var i = 0; i < threads.Length; ++i)
                (threads[i] = new Thread(TestData)).Start();
            foreach (var t in threads) t.Join();

            Console.WriteLine("");
            Console.WriteLine("Задание №2");


            for (var i = 0; i < 10; ++i)
                ThreadPool.QueueUserWorkItem(TestData2);

            ThreadPool.GetMaxThreads(out var maxThreads, out _);
            while (true)
            {
                ThreadPool.GetAvailableThreads( out var availableThreads, out _);
                if (maxThreads == availableThreads) break;
            }

            Console.ReadKey();


            void TestData()
            {
                TestBankAccount.Credit(100);
                TestBankAccount.Debit(500);
                TestBankAccount.Credit(200);
                TestBankAccount.Debit(150);
            }

            void TestData2(object state)
            {
                ClassToTask2.Method2();
                ClassToTask2.Method1();
                ClassToTask2.Method2();
                ClassToTask2.Method3();
                ClassToTask2.Method1();
                ClassToTask2.Method3();
            }






        }

       
    }
}
