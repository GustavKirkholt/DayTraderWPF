using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DayTraderWPF.ViewModels
{
    internal class DashboardViewModel : ViewModelBase
    {
        public DashBoardListViewModel DashBoardListViewModel { get; }
        public DashBoardMainViewModel DashBoardMainViewModel { get; }
        public ICommand SellStockCommand { get; }
        public ICommand BuyStockCommand { get; }

        public DashboardViewModel() 
        {
            DashBoardListViewModel = new DashBoardListViewModel();
            DashBoardMainViewModel = new DashBoardMainViewModel();
        }
    }
}
