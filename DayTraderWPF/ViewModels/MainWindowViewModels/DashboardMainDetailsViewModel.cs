using DayTraderWPF.Models;
using DayTraderWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.ViewModels
{
    internal class DashboardMainDetailsViewModel
    {
        private readonly StocksStore _selectedStocksStore;

        private Stocks SelectedStock => _selectedStocksStore.SelectedStocks;

        public string Name => SelectedStock?.Name ?? "Unknown";

        public string IsOwned => (SelectedStock?.IsOwned ?? false) ? "Yes": "No";

        public decimal HighPrice => (decimal)(SelectedStock?.HighPrice);

        public decimal LowPrice => (decimal)(SelectedStock?.LowPrice);

        public decimal Change =>  (decimal)(SelectedStock?.Change);

        public decimal Price => (decimal)(SelectedStock?.GetPrice);

        public DashboardMainDetailsViewModel(StocksStore selectedStocksStore)
        {
            _selectedStocksStore = selectedStocksStore;
        }
    }
}
