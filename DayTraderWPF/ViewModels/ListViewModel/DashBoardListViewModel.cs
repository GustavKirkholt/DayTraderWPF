using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.ViewModels
{
    internal class DashBoardListViewModel : ViewModelBase
    {

        private readonly ObservableCollection<DashBoardListItemViewModels> _dashBoardListItemViewModels;
        public IEnumerable<DashBoardListItemViewModels> dashBoardListItemViewModels => _dashBoardListItemViewModels;

        public DashBoardListViewModel() 
        {
            _dashBoardListItemViewModels = new ObservableCollection<DashBoardListItemViewModels>();

            _dashBoardListItemViewModels.Add(new DashBoardListItemViewModels("Aktie 1", 10m, 9m, 1m));
        }
    }
}
