using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.Models
{
    public class Stocks
    {
        protected decimal HighPrice;
        protected decimal LowPrice;
        protected decimal Change;
        protected decimal Opening;
        protected string Name;

        public Stocks(decimal high, decimal low, decimal change, decimal open, string n )
        {
            HighPrice = high;
            LowPrice = low;
            Change = change;
            Opening = open;
            Name = n;
        }
    }
}
