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
        public ICommand SellStockCommand { get; }
        public ICommand BuyStockCommand { get; }

        public DashBoardListViewModel DashBoardListViewModel { get; }

        public DashboardMainDetailsViewModel DashboardMainDetailsViewModel { get; }


        public DashboardViewModel() 
        {
            DashBoardListViewModel = new DashBoardListViewModel();
            DashboardMainDetailsViewModel = new DashboardMainDetailsViewModel();    
        }

    }
}
