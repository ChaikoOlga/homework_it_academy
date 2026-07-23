namespace hw5task5
{
    internal class Program
    {
        class BankAccount
        {
            private decimal _balance;
            public decimal Balance
            {
                get { return _balance; }
            }

            public void Deposit(decimal amount)
            {
                _balance += amount;
            }

            public void Withdraw(decimal amount)
            {
                if (_balance >= amount)
                {
                    _balance -= amount;
                }
                else
                {
                    Console.WriteLine("Not enough money");
                }
            }
        }

        class Programs
        {
            static void Main()
            {
                BankAccount account = new BankAccount();

                account.Deposit(100);
                account.Withdraw(30);

                Console.WriteLine(account.Balance);
            }
        }
    }
}
