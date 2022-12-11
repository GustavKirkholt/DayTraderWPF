using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DayTraderWPF.Stores;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayTraderWPF.Models;

namespace DayTraderWPF.ViewModels
{
    internal class DashBoardListViewModel : ViewModelBase
    {

        private readonly StocksStore _selectedStocksStore;

        private readonly ObservableCollection<DashBoardListItemViewModels> _dashBoardListItemViewModels;
        public IEnumerable<DashBoardListItemViewModels> dashBoardListItemViewModels => _dashBoardListItemViewModels;

        private DashBoardListItemViewModels _selectedDashBoardListItemViewModels;

        public DashBoardListItemViewModels SelectedDashBoardListItemViewModels
        {
            get 
            {
                return _selectedDashBoardListItemViewModels;
            }
            set
            {
                _selectedDashBoardListItemViewModels = value;
                OnPropertyChanged(nameof(SelectedDashBoardListItemViewModels));

                _selectedStocksStore.SelectedStocks = SelectedDashBoardListItemViewModels?.Stocks;
            }
        }

        public DashBoardListViewModel(StocksStore selectedStocksStore) 
        {
            _dashBoardListItemViewModels = new ObservableCollection<DashBoardListItemViewModels>();

            _dashBoardListItemViewModels.Add(new DashBoardListItemViewModels(new Stocks(11m, 9m, 1m, 11m, "Aktie 1", 10m, true)));

        }
    }
}
