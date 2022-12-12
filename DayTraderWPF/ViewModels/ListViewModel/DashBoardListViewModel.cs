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
    public class DashBoardListViewModel : ViewModelBase
    {

        private readonly ObservableCollection<DashBoardListItemViewModels> _DashBoardListItemViewModels;
        private readonly StocksStore _selectedStockStore;

        public IEnumerable<DashBoardListItemViewModels> DashBoardListItemViewModels => 
            _DashBoardListItemViewModels;

        private DashBoardListItemViewModels _selectedStockDashboardListItemViewModel;

        public DashBoardListItemViewModels SelectedStockDashboardListItemViewModel
        {
            get 
            {
                return _selectedStockDashboardListItemViewModel;
            }
            set 
            {
                _selectedStockDashboardListItemViewModel = value;
                OnPropertyChanged(nameof(SelectedStockDashboardListItemViewModel));

                _selectedStockStore.SelectedStock = _selectedStockDashboardListItemViewModel.Stock;
            }
        }

        public DashBoardListViewModel(StocksStore selectedStockStore)
        {
            _selectedStockStore= selectedStockStore;

            _DashBoardListItemViewModels = new ObservableCollection<DashBoardListItemViewModels>();

            _DashBoardListItemViewModels.Add(new DashBoardListItemViewModels(new Stocks(10000, 8000, 2000, 9000, "Aktie 1", 9500, true)));
            _DashBoardListItemViewModels.Add(new DashBoardListItemViewModels(new Stocks(50000, 45000, 5000, 49000, "Aktie 2", 49500, false)));
            _DashBoardListItemViewModels.Add(new DashBoardListItemViewModels(new Stocks(30000, 28000, 2000, 29000, "Aktie 3", 29000, true)));
            _DashBoardListItemViewModels.Add(new DashBoardListItemViewModels(new Stocks(20000, 8000, 12000, 10000, "Aktie 4", 18000, false)));
            
        }
    }

}
