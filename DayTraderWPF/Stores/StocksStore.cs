using DayTraderWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.Stores
{
    internal class StocksStore
    {
        private Stocks _selectedStock;

        public Stocks SelectedStocks
        {
            get 
            { 
                return _selectedStock; 
            }

            set 
            { 
                _selectedStock = value;
                SelectedStocksChanged?.Invoke();
            }
            
        }

        public event Action SelectedStocksChanged;

    }

}
