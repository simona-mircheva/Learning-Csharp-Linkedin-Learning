using System;

namespace ProgChallenge
{
    public class Account
    {
        private string _firstName;
        private string _lastName;
        public decimal Balance
        {
            get; set;
        }
        public Account(string fname, string lname, decimal initial = 0.0m)
        {
            _firstName = fname;
            _lastName = lname;
            Balance = initial;

        }
        public string AccountOwner
        {
            get => $"{_firstName} {_lastName}";
        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}