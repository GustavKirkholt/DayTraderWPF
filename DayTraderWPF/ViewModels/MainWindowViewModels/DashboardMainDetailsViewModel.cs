using DayTraderWPF.Models;
using DayTraderWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.ViewModels
{
    internal class DashboardMainDetailsViewModel : ViewModelBase
    {
        private readonly StocksStore _selectedStocksStore;

        private Stocks SelectedStock => _selectedStocksStore.SelectedStocks;

        public string Name => SelectedStock?.Name ?? "Unknown";

        public string IsOwned => (SelectedStock?.IsOwned ?? false) ? "Yes" : "No";

        public decimal HighPrice => (decimal)(SelectedStock?.HighPrice);

        public decimal LowPrice => (decimal)(SelectedStock?.LowPrice);

        public decimal Change => (decimal)(SelectedStock?.Change);

        public decimal Price => (decimal)(SelectedStock?.GetPrice);

        public DashboardMainDetailsViewModel(StocksStore selectedStocksStore)
        {
            _selectedStocksStore = selectedStocksStore;
            _selectedStocksStore.SelectedStocksChanged += StocksStore_SelectedStockChanged;

        }

        protected override void Dispose()
        {
            _selectedStocksStore.SelectedStocksChanged -= StocksStore_SelectedStockChanged;

            base.Dispose();
        }

        private void StocksStore_SelectedStockChanged()
        {
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(IsOwned));
            OnPropertyChanged(nameof(HighPrice));
            OnPropertyChanged(nameof(LowPrice));
            OnPropertyChanged(nameof(Change));
            OnPropertyChanged(nameof(Price));
        }


    }
}
