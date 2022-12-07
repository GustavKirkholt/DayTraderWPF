using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.Models
{
    public class BankAccount
    {
        protected decimal balance;
        private static BankAccount instance = new BankAccount(100M);
        private BankAccount(decimal b)
        {
            balance = b;
        }

        public static BankAccount Instance
        {
            get { return instance; }
        }

        public virtual decimal Balance
        {
            get { return balance; }
        }

        public virtual void Withdraw(decimal amount)
        {


            if (balance - amount < 0)
            {
                balance -= amount;
            }
            else Conflict();
        }

        public virtual void Deposit(decimal amount)
        {
            balance += amount;
        }

        public override string ToString()
        {
            return "account holds" +
                  +balance + " kroner";
        }

        public string Conflict()
        {

        return "Insufficient funds";

        }

    }
}
