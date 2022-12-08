using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.Models
{
    public class Stocks
    {
        protected decimal price;
        protected decimal highPrice;
        protected decimal lowPrice;
        protected decimal change;
        protected decimal opening;
        protected string name;
        protected Boolean isOwned;

        public Stocks(decimal h, decimal l, decimal change, decimal opening, string n, decimal  p, bool isOwned)
        {
            this.highPrice = h;
            this.lowPrice = l;
            this.change = change;
            this.opening = opening;
            this.name = n;
            this.price = p;
            this.isOwned = isOwned;
        }


        public virtual decimal HighPrice
        {
            get { return highPrice; }
        }

        public virtual decimal LowPrice
        {
            get { return lowPrice; }
        }

        public virtual string Name
        {
            get { return name; }
        }

        public virtual decimal Change
        {
            get { return change; }
        }

        public virtual decimal Opening
        {
            get { return opening; }
        }

        public bool IsOwned { get; internal set; }
        public decimal GetPrice { get; internal set; }

        public virtual decimal Transaction(decimal price)
        {
            return price;
        }

        public override string ToString()
        {
            return "The stock price is" +
                  +price + " kroner";
        }
    }
}
