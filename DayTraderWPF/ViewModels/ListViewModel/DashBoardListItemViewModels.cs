using DayTraderWPF.Models;
using DayTraderWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.ViewModels
{
    public class DashBoardListItemViewModels : ViewModelBase
    {
        public Stocks Stock { get; }

        public string Name => Stock.Name;

       public DashBoardListItemViewModels(Stocks stocks)
       {
            Stock = stocks;
        }
    }
}
