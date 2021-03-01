using System;
using System.Threading;

namespace HomeWork11.Classes
{
    public class BankAccount
    {
        private int _balance;
        private readonly object _locker = new object();

        public BankAccount()
        {
            _balance = 0;
        }

        public void Credit(int money)
        {
            lock (_locker)
            {
                var threadId = Thread.CurrentThread.ManagedThreadId;
                Console.Write($"Поток с Id: {threadId} \tБаланс на начало: {_balance} \t+Сумма: {money} ");
                _balance += money;
                Console.WriteLine($"\tОстаток на балансе: {_balance}");
                Thread.Sleep(100);
            }
        }

        public void Debit(int money)
        {
            lock (_locker)
            {
                var threadId = Thread.CurrentThread.ManagedThreadId;
                Console.Write($"Поток с Id: {threadId} \tБаланс на начало: {_balance} \t-Сумма: {money} ");
                if (money > _balance)
                {
                    Console.WriteLine($"\t Упс. Закончилось бабло на балансе. Операция невозможна");
                }
                else
                {
                    _balance -= money;
                    Console.WriteLine($"\tОстаток на балансе: {_balance}");
                }
                Thread.Sleep(50);
            }
        }

        public int CurrentBalance()
        {
            lock (_locker)
            {
                return _balance;
            }
        }

    }
}
