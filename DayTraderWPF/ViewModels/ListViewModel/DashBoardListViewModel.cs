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

            _DashBoardListItemViewModels.Add(new DashBoardListItemViewModels(new Stocks(10000, 8000, 2000, 9000, "A.P Møller - Mærsk A", 9500, true)));
            _DashBoardListItemViewModels.Add(new DashBoardListItemViewModels(new Stocks(50000, 45000, 5000, 49000, "Tesla, Inc.", 49500, false)));
            _DashBoardListItemViewModels.Add(new DashBoardListItemViewModels(new Stocks(30000, 28000, 2000, 29000, "Amazon.com", 29000, true)));
            _DashBoardListItemViewModels.Add(new DashBoardListItemViewModels(new Stocks(20000, 8000, 12000, 10000, "A.P Møller - Mærsk B", 18000, false)));
            _DashBoardListItemViewModels.Add(new DashBoardListItemViewModels(new Stocks(100000, 90000, 10000, 92000, "Berkshire Hathaway Inc Class A", 98000, false)));
            _DashBoardListItemViewModels.Add(new DashBoardListItemViewModels(new Stocks(500, 400, 100, 450, "Netcompany Group", 500, false)));  

        }
    }

}
