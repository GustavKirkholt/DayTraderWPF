using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.Models
{
    public class BankAccountModel
    {
        public decimal Balance { get; set; }

        public BankAccountModel(decimal balance)
        {
            Balance = balance;
        }

        public virtual void Withdraw(decimal amount)
        {


            if (Balance - amount < 0)
            {
                Balance -= amount;
            }
            else Conflict();
        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            return "account holds" +
                  +Balance + " kroner";
        }

        public string Conflict()
        {

        return "Insufficient funds";

        }

    }
}
