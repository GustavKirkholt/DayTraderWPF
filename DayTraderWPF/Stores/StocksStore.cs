using DayTraderWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.Stores
{
    public class StocksStore
    {
        private Stocks _selectedStock;

        public Stocks SelectedStock
        {
            get 
            { 
                return _selectedStock; 
            }

            set 
            { 
                _selectedStock = value;
                SelectedStockChanged?.Invoke();
            }
            
        }

        public event Action SelectedStockChanged;

    }

}
