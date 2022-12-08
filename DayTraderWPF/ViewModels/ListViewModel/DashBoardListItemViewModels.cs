using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.ViewModels
{
    internal class DashBoardListItemViewModels : ViewModelBase
    {
        public string Name { get; }
        public decimal HighPrice { get; }
        public decimal LowPrice { get; }
        public decimal Change { get; }

        public  DashBoardListItemViewModels(string name, decimal highprice, decimal lowprice, decimal change)
        {
            Name = name;
            HighPrice = highprice;
            LowPrice = lowprice;
            Change = change;
        }

    }
}
