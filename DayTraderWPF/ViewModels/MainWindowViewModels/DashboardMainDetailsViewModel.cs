using DayTraderWPF.Models;
using DayTraderWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.ViewModels
{
    public class DashboardMainDetailsViewModel : ViewModelBase
    {
        private readonly StocksStore _selectedStockStore;

        private Stocks SelectedStock => _selectedStockStore.SelectedStock;

        public string StockName => SelectedStock?.Name;
        public decimal Price => SelectedStock?.Price ?? 0;
        public decimal HighPrice => SelectedStock?.HighPrice ?? 0;
        public decimal LowPrice => SelectedStock?.LowPrice ?? 0;
        public decimal Change => SelectedStock?.Change ?? 0;
        public decimal Opening => SelectedStock?.Opening ?? 0;
        public string IsOwnedDisplay => (SelectedStock?.IsOwned ?? false) ? "Yes" : "No";

        public DashboardMainDetailsViewModel(StocksStore selectedStockStore)
        {
            _selectedStockStore= selectedStockStore;
            _selectedStockStore.SelectedStockChanged += SelectedStockStore_SelectedStockChanged;
           
           
        }

        private void SelectedStockStore_SelectedStockChanged() 
        {
            OnPropertyChanged(nameof(StockName));
            OnPropertyChanged(nameof(Price));
            OnPropertyChanged(nameof(HighPrice));
            OnPropertyChanged(nameof(LowPrice));
            OnPropertyChanged(nameof(Change));
            OnPropertyChanged(nameof(Opening));
            OnPropertyChanged(nameof(IsOwnedDisplay));
            
        }

    }
}
