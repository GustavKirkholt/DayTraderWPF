using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.Models
{
    public class Stocks
    {
        public decimal Price { get; }
        public decimal HighPrice { get; }
        public decimal LowPrice { get; }
        public decimal Change { get; }
        public decimal Opening { get; }
        public string Name { get; }
        public Boolean IsOwned { get; set; }

        public Stocks(decimal highprice, decimal lowprice, decimal change, decimal opening, string name, decimal price, bool isOwned)
        {
            HighPrice = highprice;
            LowPrice = lowprice;
            Change = change;
            Opening = opening;
            Name = name;
            Price = price;
            IsOwned = isOwned;
        }

        public virtual decimal Transaction(decimal price)
        {
            return price;
        }

        public override string ToString()
        {
            return "The stock price is" +
                  +Price + " kroner";
        }
    }
}
