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
        public BankAccount(decimal b)
        {
            balance = b;
        }

        public BankAccount() :
          this(0.0M)
        {
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
