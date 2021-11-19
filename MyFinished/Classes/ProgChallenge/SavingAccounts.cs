using System;

namespace ProgChallenge
{
    public class SavingsAcct : Account
    {
        private int _withdrawCount = 0;
        private const decimal withdrawAmount = 2.0m;
        private const int withdrawLimit = 3;

        public SavingsAcct(string fname, string lname, decimal interest, decimal initial)
            : base(fname, lname, initial)
        {
            InterestRate = interest;
        }
        public decimal InterestRate
        {
            get; set;
        }
        public void ApplyInterest()
        {
            Balance += (Balance * InterestRate);
        }
        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Attempt to overdraw savings is denied");
            }
            else
            {
                base.Withdraw(amount);

                _withdrawCount++;

                if (_withdrawCount > withdrawLimit)
                {
                    Console.WriteLine("More than 3 withdrawals. An extra charge is applied.");
                    base.Withdraw(withdrawAmount);
                }
            }
        }
    }
}