using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayTraderWPF.Stores;
using System.Windows.Input;

namespace DayTraderWPF.ViewModels
{
    internal class DashboardViewModel : ViewModelBase
    {
        public DashBoardListViewModel DashBoardListViewModel { get; }
        public DashBoardListItemViewModels DashBoardListItemViewModels { get; }
        public DashboardMainDetailsViewModel DashboardMainDetailsViewModel { get; }
        public ICommand SellStockCommand { get; }
        public ICommand BuyStockCommand { get; }

        public DashboardViewModel(StocksStore _selectedStocksStore) 
        {
            DashBoardListViewModel = new DashBoardListViewModel(_selectedStocksStore);
            DashBoardListItemViewModels = new DashBoardListItemViewModels(_selectedStocksStore);
            DashboardMainDetailsViewModel = new DashboardMainDetailsViewModel(_selectedStocksStore);
        }
    }
}
