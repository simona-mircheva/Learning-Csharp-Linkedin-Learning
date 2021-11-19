using System;

namespace ProgChallenge
{
    public class CheckingAcct : Account
    {
        private const decimal Overdraw = 35.0m;

        public CheckingAcct(string fname, string lname, decimal initial)
            : base(fname, lname, initial)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                amount += Overdraw;
            }
            base.Withdraw(amount);
        }
    }
}