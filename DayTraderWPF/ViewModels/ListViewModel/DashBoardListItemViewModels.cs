using DayTraderWPF.Models;
using DayTraderWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.ViewModels
{
    internal class DashBoardListItemViewModels : ViewModelBase
    {
        private StocksStore selectedStocksStore;

        public Stocks Stocks { get; }

        public string Name =>  Stocks.Name;
        public decimal HighPrice => Stocks.HighPrice;
        public decimal LowPrice => Stocks.LowPrice;
        public decimal Change => Stocks.Change;
        public decimal Price => Stocks.GetPrice;
        public decimal Open => Stocks.Opening;
        public Boolean isOwned => Stocks.IsOwned;


        public DashBoardListItemViewModels(Stocks stocks)
        {
            this.Stocks = stocks;
        }

        public DashBoardListItemViewModels(StocksStore selectedStocksStore)
        {
            this.selectedStocksStore = selectedStocksStore;
        }
    }
}
